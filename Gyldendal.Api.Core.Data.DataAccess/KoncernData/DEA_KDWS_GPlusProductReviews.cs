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
    
    public partial class DEA_KDWS_GPlusProductReviews
    {
        public int id { get; set; }
        public string vare { get; set; }
        public string tekst { get; set; }
        public int kd_id { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public decimal kd_slettet { get; set; }
        public System.DateTime kd_oprettet { get; set; }
        public string kortomBogen { get; set; }
        public bool ishtml { get; set; }
        public string ReviewSource { get; set; }
        public string ReviewBy { get; set; }
        public Nullable<System.DateTime> Dato { get; set; }
    
        public virtual DEA_KDWS_GPlusproduct DEA_KDWS_GPlusproduct { get; set; }
    }
}
