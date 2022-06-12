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
    
    public partial class Campaign
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Campaign()
        {
            this.CampaignItem = new HashSet<CampaignItem>();
            this.CampaignMembership = new HashSet<CampaignMembership>();
        }
    
        public int Id { get; set; }
        public string ShopName { get; set; }
        public string Title { get; set; }
        public byte CampaignType { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string CouponCode { get; set; }
        public string MediaType { get; set; }
        public string Forlag { get; set; }
        public string Afdeling { get; set; }
        public string RebateGroup { get; set; }
        public string Distributor { get; set; }
        public Nullable<decimal> DiscountPercentage { get; set; }
        public Nullable<decimal> SpecialPrice { get; set; }
        public byte DiscountType { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.DateTime> ClosedOn { get; set; }
        public string ClosedBy { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedAt { get; set; }
        public Nullable<bool> FreeShipping { get; set; }
        public Nullable<int> MaxQuantityAllowed { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CampaignItem> CampaignItem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CampaignMembership> CampaignMembership { get; set; }
    }
}
