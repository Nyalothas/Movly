using System;
using System.ComponentModel.DataAnnotations;

namespace Movly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name")] //with this attribute, the column name will no longer be nullable
        [StringLength(255)] //max number of characters for the column
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }
        
        public MembershipType MembershipType { get; set; } //navigation property\

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Date of Birth")] //if we change this name code needs to be recompiled
        public DateTime? BirthDate { get; set; }
    }
}