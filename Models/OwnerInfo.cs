//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace A2_HTML5_Biz_App_New.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OwnerInfo
    {
        public OwnerInfo()
        {
            this.OwnerPropertyDescriptions = new HashSet<OwnerPropertyDescription>();
        }
    
        public int OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Contact1 { get; set; }
        public string Contact2 { get; set; }
        public string Email { get; set; }
        public System.DateTime RegistrationDate { get; set; }
    
        public virtual ICollection<OwnerPropertyDescription> OwnerPropertyDescriptions { get; set; }
    }
}