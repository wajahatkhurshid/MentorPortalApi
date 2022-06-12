﻿using System;
using System.Linq;

namespace Gyldendal.Api.CoreData.SolrContracts.Product
{
    /// <summary>
    /// Utility methods supporting the contract classes.
    /// </summary>
    public static class Utils
    {
        /// <summary>
        /// Gets the Solr schmea field name, against the provided ProductSchemaField enumeration member.
        /// </summary>
        /// <param name="schemaField"></param>
        /// <returns></returns>
        public static string GetFieldName(this ProductSchemaField schemaField)
        {
            var memberInfo = typeof(ProductSchemaField).GetMember(schemaField.ToString()).FirstOrDefault();

            if (memberInfo == null)
            {
                throw new ArgumentException("Invalid value passed for the argument of enumeration type ProductSchemaField.");
            }

            var attribute = (ProductSchemaFieldMetaAttribute)memberInfo.GetCustomAttributes(typeof(ProductSchemaFieldMetaAttribute), false).FirstOrDefault();

            if (attribute == null)
            {
                throw new ArgumentException("The passd ProductSchemaField enumeration memeber as no ProductSchemaFieldMetaAttribute defined on it.");
            }

            return attribute.SolrFieldName;
        }
    }
}