//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Session4V2
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderItem
    {
        public long ID { get; set; }
        public long OrderID { get; set; }
        public long PartID { get; set; }
        public string BatchNumber { get; set; }
        public decimal Amount { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Part Part { get; set; }
    }
}
