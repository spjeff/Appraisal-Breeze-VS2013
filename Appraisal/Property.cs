//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Appraisal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Property
    {
        public Property()
        {
            this.Review = new HashSet<Review>();
        }
    
        public int ID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string LoanOfficer { get; set; }
        public string Status { get; set; }
    
        public virtual ICollection<Review> Review { get; set; }
    }
}