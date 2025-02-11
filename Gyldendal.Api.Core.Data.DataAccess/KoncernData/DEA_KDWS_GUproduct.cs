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
    
    public partial class DEA_KDWS_GUproduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DEA_KDWS_GUproduct()
        {
            this.DEA_KDWS_GUattachments = new HashSet<DEA_KDWS_GUattachments>();
            this.DEA_KDWS_GUBundle_Products = new HashSet<DEA_KDWS_GUBundle_Products>();
            this.DEA_KDWS_GUProductReviews = new HashSet<DEA_KDWS_GUProductReviews>();
            this.DEA_KDWS_GUproductauthors = new HashSet<DEA_KDWS_GUproductauthors>();
            this.DEA_KDWS_GUProductCategories = new HashSet<DEA_KDWS_GUProductCategories>();
            this.DEA_KDWS_GUproductcontributors = new HashSet<DEA_KDWS_GUproductcontributors>();
            this.DEA_KDWS_GUProductLevels = new HashSet<DEA_KDWS_GUProductLevels>();
            this.DEA_KDWS_GUproductseries = new HashSet<DEA_KDWS_GUproductseries>();
            this.DEA_KDWS_GUProductThemacode = new HashSet<DEA_KDWS_GUProductThemacode>();
        }
    
        public string vare_id { get; set; }
        public Nullable<System.DateTime> updated { get; set; }
        public string kortbeskrivelse { get; set; }
        public string langbeskrivelse { get; set; }
        public Nullable<int> sider { get; set; }
        public string forside { get; set; }
        public string ISBN13 { get; set; }
        public string ostSBN { get; set; }
        public string titel { get; set; }
        public string undertitel { get; set; }
        public Nullable<int> udgave { get; set; }
        public string medietype { get; set; }
        public Nullable<System.DateTime> udgivelsesdato { get; set; }
        public string Oversaetter { get; set; }
        public string illustrator { get; set; }
        public string omslagsgrafiker { get; set; }
        public Nullable<decimal> vejledende_pris { get; set; }
        public string status { get; set; }
        public string ITunesLink { get; set; }
        public string AndroidLink { get; set; }
        public Nullable<int> work_id { get; set; }
        public string materialetype { get; set; }
        public string SEO_Text { get; set; }
        public Nullable<int> lagertal { get; set; }
        public string Website { get; set; }
        public string Url { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public string redaktion { get; set; }
        public Nullable<int> serier_id { get; set; }
        public string serier_name { get; set; }
        public Nullable<int> medietypeRank { get; set; }
        public Nullable<int> materialetypeRank { get; set; }
        public string Indlaeser { get; set; }
        public Nullable<decimal> pris_med_moms { get; set; }
        public string længde { get; set; }
        public string ErrorCode { get; set; }
        public string ParentISBN { get; set; }
        public Nullable<decimal> salgbar { get; set; }
        public Nullable<decimal> pris_uden_moms { get; set; }
        public string distributor { get; set; }
        public string forlag { get; set; }
        public string beskrivelse { get; set; }
        public string undskyldningskode { get; set; }
        public string spilletid { get; set; }
        public string Review_text { get; set; }
        public Nullable<decimal> gennemsynseksemplar { get; set; }
        public string ReadingSamples { get; set; }
        public Nullable<bool> InspectionCopyAllowed { get; set; }
        public bool IsNextPrintRunPlanned { get; set; }
        public string PrintingNum { get; set; }
        public Nullable<double> Gross_weight { get; set; }
        public Nullable<double> Net_weight { get; set; }
        public Nullable<int> Height { get; set; }
        public Nullable<int> Width { get; set; }
        public Nullable<int> Thickness_depth { get; set; }
        public Nullable<System.DateTime> FirstPrintPublishDate { get; set; }
        public string Medarbejder { get; set; }
        public string Imprint { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEA_KDWS_GUattachments> DEA_KDWS_GUattachments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEA_KDWS_GUBundle_Products> DEA_KDWS_GUBundle_Products { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEA_KDWS_GUProductReviews> DEA_KDWS_GUProductReviews { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEA_KDWS_GUproductauthors> DEA_KDWS_GUproductauthors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEA_KDWS_GUProductCategories> DEA_KDWS_GUProductCategories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEA_KDWS_GUproductcontributors> DEA_KDWS_GUproductcontributors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEA_KDWS_GUProductLevels> DEA_KDWS_GUProductLevels { get; set; }
        public virtual DEA_KDWS_GUwork DEA_KDWS_GUwork { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEA_KDWS_GUproductseries> DEA_KDWS_GUproductseries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEA_KDWS_GUProductThemacode> DEA_KDWS_GUProductThemacode { get; set; }
    }
}
