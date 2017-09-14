using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Movly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required] //with this attribute, the column name will no longer be nullable
        [StringLength(255)] //max number of characters for the column
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; } //navigation property\
        public byte MembershipTypeId { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}