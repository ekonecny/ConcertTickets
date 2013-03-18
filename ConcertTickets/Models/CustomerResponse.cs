using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ConcertTickets.Models
{
    public class CustomerResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your mailing address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage="Please select a show")]
        public string Show { get; set; }

        [Required(ErrorMessage = "Please enter a quantity")]
        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be a positive number")]
        public int Quantity { get; set; }

        [Required(ErrorMessage="Please specify how you would like to receive your tickets")]
        public bool? MailTickets { get; set; }
    }
}