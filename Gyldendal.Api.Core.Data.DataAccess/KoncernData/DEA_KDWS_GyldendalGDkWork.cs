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
    
    public partial class DEA_KDWS_GyldendalGDkWork
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DEA_KDWS_GyldendalGDkWork()
        {
            this.DEA_KDWS_GyldendalGDKWorkReview = new HashSet<DEA_KDWS_GyldendalGDKWorkReview>();
        }
    
        public int work_id { get; set; }
        public string titel { get; set; }
        public string undertitel { get; set; }
        public string langbeskrivelse { get; set; }
        public Nullable<System.DateTime> Oprettelsesdato { get; set; }
        public Nullable<System.DateTime> Opdateringsdato { get; set; }
        public Nullable<System.DateTime> publiceringsdato { get; set; }
        public string forside { get; set; }
        public string WorkLabel { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public Nullable<System.DateTime> lastupdated { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEA_KDWS_GyldendalGDKWorkReview> DEA_KDWS_GyldendalGDKWorkReview { get; set; }
    }
}
