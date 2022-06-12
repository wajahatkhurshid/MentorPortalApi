﻿using Gyldendal.Api.CoreData.Business.Repositories.Common;
using Gyldendal.Api.CoreData.Common.RepositoriesInfrastructure.Repositories;
using Gyldendal.Api.CoreData.Contracts.Enumerations;
using Gyldendal.Api.CoreData.Contracts.Models;
using Gyldendal.Api.CoreData.DataAccess.KoncernData;
using System.Collections.Generic;
using System.Linq;

namespace Gyldendal.Api.CoreData.Business.Repositories.HR
{
    public class MasterDataRepository : BaseRepository, IMasterDataRepository
    {
        public MasterDataRepository(koncerndata_webshops_Entities kdEntities) :
            base(DataScope.HansReitzelShop, kdEntities)
        {
        }

        /// <summary>
        /// Get Media Types of Hr Shop from KD
        /// </summary>
        /// <returns></returns>
        public IEnumerable<MediaType> GetMediaTypes()
        {
            var mediaTypes = KdEntities.DEA_KDWS_HRmedietype
                          .Where(x => x.website_medietype != null)
                          .Select(x => x.website_medietype).Distinct().ToArray().Select(x => new MediaType
                          {
                              Name = x,
                              WebShop = WebShop
                          }).ToList();
            return mediaTypes;
        }

        /// <summary>
        /// Get Areas of Hr Shop from KD
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Area> GetAreas()
        {
            var areaCategories = KdEntities.DEA_KDWS_HRcategory.Where(x => x.niveau == 4);

            var areas = areaCategories.Select(a => new Area
            {
                Id = a.id,
                Name = a.navn.Trim(),
                WebShop = WebShop,
            })
                     .ToList();
            return areas;
        }

        /// <summary>
        /// Get Subjects of Hr Shop from KD
        /// </summary>
        /// <param name="areaId"></param>
        /// <returns></returns>
        public IEnumerable<Subject> GetSubjects(int areaId)
        {
            var subjects = KdEntities.DEA_KDWS_HRcategory
                           .Where(x => x.niveau == 5 && (areaId == 0 || x.parent == areaId))
                           .Select(a => new Subject()
                           {
                               Id = a.id,
                               Name = a.navn.Trim(),
                               WebShop = WebShop,
                               AreaId = a.parent
                           })
                            .ToList();
            return subjects;
        }

        /// <summary>
        /// Returns the SubAreas against a subejct id.
        /// </summary>
        /// <param name="subjectId"></param>
        /// <returns></returns>
        public IEnumerable<SubArea> GetSubAreas(int subjectId)
        {
            var subAreas =
                KdEntities.DEA_KDWS_HRcategory
                .Where(x => x.niveau == 6 && (subjectId == 0 || x.parent == subjectId))
                .Select(a => new SubArea
                {
                    Id = a.id,
                    Name = a.navn.Trim(),
                    WebShop = WebShop,
                    SubjectId = subjectId
                })
                .ToList();

            return subAreas;
        }

        /// <summary>
        /// Get Levels of Hr Shop from KD
        /// </summary>
        /// <param name="areaId"></param>
        /// <returns></returns>
        public IEnumerable<Level> GetLevels(int areaId)
        {
            var kdLevels = KdEntities.DEA_KDWS_HR_LevelCategoriesView
                     .Where(l => areaId == 0 || l.kategori_id == areaId)
                     .GroupBy(l => l.navn).ToList()
                     .Select(g => g.First())
                     .OrderBy(l => l.niveau)
                     .Select(l => new Level()
                     {
                         Name = l.navn,
                         LevelNumber = l.niveau,
                         WebShop = WebShop,
                         AreaId = areaId == 0 ? 0 : l.kategori_id
                     }).ToList();
            return kdLevels;
        }

        /// <summary>
        /// Gets Material Types of Gu Shop from KD
        /// </summary>
        /// <returns></returns>
        public IEnumerable<MaterialType> GetMaterialTypes()
        {
            var materialTypes = KdEntities.DEA_KDWS_HRmaterialtype
                      .Where(m => m.website_materialtype != null)
                      .Select(x => x.website_materialtype).Distinct().ToArray().Select(x => new MaterialType
                      {
                          Name = x,
                          WebShop = WebShop
                      }).ToList();
            return materialTypes;
        }
    }
}