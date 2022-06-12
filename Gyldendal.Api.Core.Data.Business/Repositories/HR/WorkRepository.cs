﻿using Gyldendal.Api.CoreData.Business.Repositories.Common;
using Gyldendal.Api.CoreData.Business.Util;
using Gyldendal.Api.CoreData.Common.ConfigurationManager;
using Gyldendal.Api.CoreData.Common.RepositoriesInfrastructure.Repositories;
using Gyldendal.Api.CoreData.Contracts.Enumerations;
using Gyldendal.Api.CoreData.Contracts.Response;
using Gyldendal.Api.CoreData.DataAccess.KoncernData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Gyldendal.Api.CoreData.Business.Repositories.HR
{
    public class WorkRepository : BaseWorkProductRepository, IWorkRepository
    {
        private readonly ShopServices.ApiClient.Client _shopServicesApiClient;

        private readonly ICoverImageUtil _imageUtil;

        private readonly IConfigurationManager _configurationManager;

        /// <summary>
        /// Constructor of Hr work Repository
        /// </summary>
        /// <param name="kdEntities"></param>
        /// <param name="shopServicesApiClient"></param>
        /// <param name="imageUtil"></param>
        /// <param name="configurationManager"></param>
        public WorkRepository(koncerndata_webshops_Entities kdEntities, ShopServices.ApiClient.Client shopServicesApiClient, ICoverImageUtil imageUtil, IConfigurationManager configurationManager) :
            base(kdEntities)
        {
            _shopServicesApiClient = shopServicesApiClient;
            _imageUtil = imageUtil;
            _configurationManager = configurationManager;
        }

        /// <summary>
        /// Returns Deleted Work Ids of Hr webshop
        /// </summary>
        /// <param name="fromDate"></param>
        /// <returns></returns>
        public List<string> GetDeletedWorks(DateTime? fromDate)
        {
            if (!fromDate.HasValue)
            {
                fromDate = DateTime.MinValue;
            }
            return KdEntities.DEA_KDWS_HRWorkLog
                .Where(w => w.Action.Equals(Constants.DeleteAction) && w.CreatedDate >= fromDate)
                .Select(w => w.work_id.ToString())
                .ToList();
        }

        /// <summary>
        /// Returns work object with product details
        /// </summary>
        /// <param name="id"></param>
        /// <param name="productType"></param>
        /// <returns></returns>
        public GetProductDetailsResponse GetWorkByProductId(string id, ProductType productType)
        {
            switch (productType)
            {
                case ProductType.SingleProduct:
                    return GetProductByIsbn(id);

                case ProductType.Bundle:
                    return GetBundleById(id);

                default:
                    throw new InvalidDataException($"Product Type: {productType} is not correct");
            }
        }

        public GetScopeWorksByProductIdResponse GetScopeWorks(string isbn)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the Category objects agains the provided ISBN.
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns></returns>
        private IEnumerable<DEA_KDWS_HRcategory> GetProductCategories(string isbn)
        {
            return
                (from prodCatView in KdEntities.DEA_KDWS_HR_ProductCategoriesView
                 join category in KdEntities.DEA_KDWS_HRcategory on prodCatView.kategori equals category.id
                 where prodCatView.Vare_id == isbn
                 select category).ToArray();
        }

        /// <summary>
        /// return Work (Product) from kencernData base on isbn
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns></returns>
        private GetProductDetailsResponse GetProductByIsbn(string isbn)
        {
            var hrProduct = KdEntities.DEA_KDWS_HRproduct
                      .Include("DEA_KDWS_HRproductseries.DEA_KDWS_HRseries")
                      .Include("DEA_KDWS_HRproductcontributors.DEA_KDWS_HRContributors")
                      .Include("DEA_KDWS_HRProductCategories.DEA_KDWS_HRcategory")
                      .Include("DEA_KDWS_HRProductLevels.DEA_KDWS_HRlevel")
                      .Include("DEA_KDWS_HRwork")
                      .FirstOrDefault(p => p.vare_id.Equals(isbn));

            if (hrProduct?.DEA_KDWS_HRwork == null)
            {
                return new GetProductDetailsResponse
                {
                    Message = "Product not found in KD.",
                    ProductNotFoundReason = ProductNotFoundReason.NoProductFoundInKd
                };
            }

            var prodCategories = GetProductCategories(isbn);

            var work = hrProduct.ToCoreDataWork(prodCategories.ToArray(), _shopServicesApiClient, _imageUtil, _configurationManager, HasFreeSupplementaryMaterial(isbn));
            work.Products.ForEach(product =>
            {
                product.HasOtherDiscount = HasOtherDiscounts(product.Isbn13, product.MediaType.Name);
                product.DiscountPercentage = GetProductDiscount(product.Isbn13, product.MediaType.Name);
                product.FreeMaterials = GetFreeMaterials(product.Isbn13);
                product.IsBuyable = IsProductBuyable(product);
            });

            return new GetProductDetailsResponse
            {
                Message = "",
                ProductNotFoundReason = ProductNotFoundReason.None,
                ProductWork = work
            };
        }

        /// <summary>
        /// return Work(Bundle) from kencernData base on id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private GetProductDetailsResponse GetBundleById(string id)
        {
            var kdBundleCategories = (from kdbundle in KdEntities.DEA_KDWS_HRBundle
                                      where kdbundle.bundle_id.Equals(id)
                                      let kdCategories = (from kdcategory in KdEntities.DEA_KDWS_HRcategory
                                                          join kdbundleCategory in KdEntities.DEA_KDWS_HR_BundleCategoriesView on kdcategory.id equals kdbundleCategory.kategori
                                                          where kdbundleCategory.Bundle_id.Equals(id)
                                                          select kdcategory)
                                      select new { Bundle = kdbundle, Categories = kdCategories }).FirstOrDefault();

            if (kdBundleCategories?.Bundle == null)
            {
                return new GetProductDetailsResponse
                {
                    Message = "Product not found in KD.",
                    ProductNotFoundReason = ProductNotFoundReason.NoProductFoundInKd
                };
            }

            var work = kdBundleCategories.Bundle.ToCoreDataWork(kdBundleCategories.Categories.ToArray(),
                _shopServicesApiClient, _imageUtil, _configurationManager);
            work.Products.ForEach(bundleProducts => bundleProducts.IsBuyable = IsBundleBuyable(bundleProducts));

            return new GetProductDetailsResponse
            {
                Message = "",
                ProductNotFoundReason = ProductNotFoundReason.None,
                ProductWork = work
            };
        }
    }
}