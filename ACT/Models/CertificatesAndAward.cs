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
    
    public partial class CertificatesAndAward
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public System.DateTime DateOfCertificate { get; set; }
        public decimal UserId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        public virtual User User { get; set; }
    }
}
