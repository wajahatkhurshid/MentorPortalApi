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
    
    public partial class DEA_KDWS_GPluscategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DEA_KDWS_GPluscategory()
        {
            this.DEA_KDWS_GPluslevel = new HashSet<DEA_KDWS_GPluslevel>();
            this.DEA_KDWS_GPlusProductCategories = new HashSet<DEA_KDWS_GPlusProductCategories>();
            this.DEA_KDWS_GPlusSerieCategories = new HashSet<DEA_KDWS_GPlusSerieCategories>();
        }
    
        public int id { get; set; }
        public string navn { get; set; }
        public Nullable<short> niveau { get; set; }
        public string sti { get; set; }
        public string parent_sti { get; set; }
        public Nullable<int> parent { get; set; }
        public Nullable<System.DateTime> opdateret { get; set; }
        public string website { get; set; }
        public Nullable<bool> GU_serie { get; set; }
        public Nullable<int> GU_serie_id { get; set; }
        public string GU_seriebeskrivelse { get; set; }
        public string GU_seriebilled { get; set; }
        public Nullable<int> GU_kategori_id { get; set; }
        public string GU_klassetrin { get; set; }
        public string GU_seriebeskrivelseXS { get; set; }
        public string SEOtitle { get; set; }
        public string SEOdescription { get; set; }
        public string TitleXML { get; set; }
        public System.DateTime LastUpdated { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEA_KDWS_GPluslevel> DEA_KDWS_GPluslevel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEA_KDWS_GPlusProductCategories> DEA_KDWS_GPlusProductCategories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEA_KDWS_GPlusSerieCategories> DEA_KDWS_GPlusSerieCategories { get; set; }
    }
}
