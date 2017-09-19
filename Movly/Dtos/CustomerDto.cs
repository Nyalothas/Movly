using Movly.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace Movly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required] //with this attribute, the column name will no longer be nullable
        [StringLength(255)] //max number of characters for the column
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public byte MembershipTypeId { get; set; }

        [Min18YearsIfAMember] //custom Validation
        public DateTime? BirthDate { get; set; }
    }
}