//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ACT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SubIndicatorsCategory
    {
        public decimal Id { get; set; }
        public decimal TargetCategory { get; set; }
        public decimal CategoryId { get; set; }
        public decimal ItemId { get; set; }
        public decimal StandardId { get; set; }
        public bool IsContinuous { get; set; }
        public string Quantity { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual Standard Standard { get; set; }
        public virtual UserCategory UserCategory { get; set; }
        public virtual UserCategory UserCategory1 { get; set; }
    }
}