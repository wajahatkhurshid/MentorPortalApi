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
    
    public partial class DEA_KDWS_GUThemacode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DEA_KDWS_GUThemacode()
        {
            this.DEA_KDWS_GUProductThemacode = new HashSet<DEA_KDWS_GUProductThemacode>();
        }
    
        public int ThemaCodeId { get; set; }
        public string ThemaCode { get; set; }
        public string DanishDescription { get; set; }
        public string EnglishDescription { get; set; }
        public string ThemaType { get; set; }
        public Nullable<int> ParentId { get; set; }
        public string WarningSuggestionMessage { get; set; }
        public string ToolTipMessage { get; set; }
        public Nullable<bool> HasChilds { get; set; }
        public System.DateTime LastUpdated { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEA_KDWS_GUProductThemacode> DEA_KDWS_GUProductThemacode { get; set; }
    }
}
