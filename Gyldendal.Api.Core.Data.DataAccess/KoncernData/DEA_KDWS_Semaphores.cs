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
    
    public partial class DEA_KDWS_Semaphores
    {
        public short Id { get; set; }
        public Nullable<short> WebShopId { get; set; }
        public string WebShopName { get; set; }
        public Nullable<System.DateTime> StartTimeStamp { get; set; }
        public Nullable<System.DateTime> EndTimestamp { get; set; }
        public bool ExecStatus { get; set; }
        public int ErrorCode { get; set; }
    }
}
