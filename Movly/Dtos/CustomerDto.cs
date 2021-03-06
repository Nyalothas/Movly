﻿using System;
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

        public MembershipTypeDto MembershipType { get; set; }

        public byte MembershipTypeId { get; set; }

        //[Min18YearsIfAMember] //will get error here cause we cast to Customer
        public DateTime? BirthDate { get; set; }
    }
}