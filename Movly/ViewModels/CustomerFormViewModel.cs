using Movly.Models;
using System.Collections.Generic;

namespace Movly.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }

        public string Title
        {
            get
            {
                return (Customer.Id != 0) ? "Edit Customer" : "New Customer";
            }
        }
    }
}