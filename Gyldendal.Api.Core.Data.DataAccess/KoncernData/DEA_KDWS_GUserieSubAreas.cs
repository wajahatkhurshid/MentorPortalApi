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
    
    public partial class DEA_KDWS_GUserieSubAreas
    {
        public int Id { get; set; }
        public int serie { get; set; }
        public string subarea { get; set; }
        public int subjectId { get; set; }
        public int SubAreaId { get; set; }
    
        public virtual DEA_KDWS_GUseries DEA_KDWS_GUseries { get; set; }
    }
}
