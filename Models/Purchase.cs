using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreProject.Models
{
    public class Purchase
    {
        [Key]
        [BindNever]
        public int PurchaseId { get; set; }

        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }

        [Required(ErrorMessage = "Please enter a name:")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a name:")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }

        [Required(ErrorMessage = "Please enter a City:")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter a State:")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter a Zipcode:")]
        public string Zipcode { get; set; }

        [Required(ErrorMessage = "Please enter a Country:")]
        public string Country { get; set; }

        public bool Anonymous { get; set; }
    }
}
