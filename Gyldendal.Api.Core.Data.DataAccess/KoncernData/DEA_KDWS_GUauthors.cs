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
    
    public partial class DEA_KDWS_GUauthors
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DEA_KDWS_GUauthors()
        {
            this.DEA_KDWS_GUproductauthors = new HashSet<DEA_KDWS_GUproductauthors>();
        }
    
        public string forfatter_id { get; set; }
        public string forfatter_navn { get; set; }
        public string forfatter_langbeskrivelse { get; set; }
        public string forfatter_foto { get; set; }
        public string forfatter_langBeskrivelse_tekst { get; set; }
        public string forfatter_fornavn { get; set; }
        public string forfatter_efternavn { get; set; }
        public string forfatter_profileLink { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public string Forfatternr { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEA_KDWS_GUproductauthors> DEA_KDWS_GUproductauthors { get; set; }
    }
}
