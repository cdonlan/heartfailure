//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HeartFailureReaddminssion.Models.WorkflowTracking
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookmarkResumptionEventsTable
    {
        public int Id { get; set; }
        public System.Guid WorkflowInstanceId { get; set; }
        public Nullable<long> RecordNumber { get; set; }
        public Nullable<byte> TraceLevelId { get; set; }
        public string BookmarkName { get; set; }
        public Nullable<System.Guid> BookmarkScope { get; set; }
        public string OwnerActivityName { get; set; }
        public string OwnerActivityId { get; set; }
        public string OwnerActivityInstanceId { get; set; }
        public string OwnerActivityType { get; set; }
        public string SerializedAnnotations { get; set; }
        public System.DateTime TimeCreated { get; set; }
    }
}