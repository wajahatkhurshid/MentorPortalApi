//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gyldendal.Api.CoreData.DataAccess.KoncernData
{
    using System;
    using System.Collections.Generic;
    
    public partial class DEA_KDWS_HRProductCategories
    {
        public string vare { get; set; }
        public int kategori { get; set; }
        public Nullable<int> sortering { get; set; }
        public System.DateTime LastUpdated { get; set; }
    
        public virtual DEA_KDWS_HRcategory DEA_KDWS_HRcategory { get; set; }
        public virtual DEA_KDWS_HRproduct DEA_KDWS_HRproduct { get; set; }
    }
}
