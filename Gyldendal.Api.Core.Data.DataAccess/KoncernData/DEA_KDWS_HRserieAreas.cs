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
    
    public partial class DEA_KDWS_HRserieAreas
    {
        public int Id { get; set; }
        public int serie { get; set; }
        public string area { get; set; }
        public int AreaId { get; set; }
    
        public virtual DEA_KDWS_HRseries DEA_KDWS_HRseries { get; set; }
    }
}
