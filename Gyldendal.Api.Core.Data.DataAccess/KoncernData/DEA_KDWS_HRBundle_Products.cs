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
    
    public partial class DEA_KDWS_HRBundle_Products
    {
        public string bundle { get; set; }
        public string product { get; set; }
        public int antal { get; set; }
        public int sequence { get; set; }
        public int id { get; set; }
        public Nullable<decimal> discount_percentage { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public Nullable<System.DateTime> updated { get; set; }
    
        public virtual DEA_KDWS_HRBundle DEA_KDWS_HRBundle { get; set; }
        public virtual DEA_KDWS_HRproduct DEA_KDWS_HRproduct { get; set; }
    }
}
