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
    
    public partial class DEA_KDWS_GUContributors
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DEA_KDWS_GUContributors()
        {
            this.DEA_KDWS_GUproductcontributors = new HashSet<DEA_KDWS_GUproductcontributors>();
        }
    
        public string contributor_id { get; set; }
        public string contributor_navn { get; set; }
        public string contributor_langbeskrivelse { get; set; }
        public string contributor_foto { get; set; }
        public string contributor_langBeskrivelse_tekst { get; set; }
        public string contributor_fornavn { get; set; }
        public string contributor_efternavn { get; set; }
        public string contributor_profileLink { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public string Forfatternr { get; set; }
        public string contributor_information { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEA_KDWS_GUproductcontributors> DEA_KDWS_GUproductcontributors { get; set; }
    }
}
