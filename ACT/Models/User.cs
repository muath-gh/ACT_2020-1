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
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Level1 = new HashSet<Level1>();
            this.Level2 = new HashSet<Level2>();
            this.Level3 = new HashSet<Level3>();
            this.Level4 = new HashSet<Level4>();
            this.CertificatesAndAwards = new HashSet<CertificatesAndAward>();
            this.Courses = new HashSet<Course>();
            this.Qualifications = new HashSet<Qualification>();
            this.UnitUsers = new HashSet<UnitUser>();
        }
    
        public decimal Id { get; set; }
        public Nullable<decimal> Level1Id { get; set; }
        public Nullable<decimal> Level2Id { get; set; }
        public Nullable<decimal> Level3Id { get; set; }
        public Nullable<decimal> Level4Id { get; set; }
        public decimal UserCategoryId { get; set; }
        public decimal JobTitleId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public Nullable<decimal> CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<decimal> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string AnotherPhoneNumber { get; set; }
        public short GenderId { get; set; }
        public string Address { get; set; }
        public string FirstNameEn { get; set; }
        public string LastNameEn { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Level1> Level1 { get; set; }
        public virtual Level1 Level11 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Level2> Level2 { get; set; }
        public virtual Level2 Level21 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Level3> Level3 { get; set; }
        public virtual Level3 Level31 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Level4> Level4 { get; set; }
        public virtual Level4 Level41 { get; set; }
        public virtual JobTitle JobTitle { get; set; }
        public virtual UserCategory UserCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CertificatesAndAward> CertificatesAndAwards { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course> Courses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Qualification> Qualifications { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UnitUser> UnitUsers { get; set; }
    }
}
