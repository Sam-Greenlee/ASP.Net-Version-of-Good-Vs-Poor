using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assignment_4.Models
{
    public class Registrations
    {
        [Required(ErrorMessage = "Please enter your first name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your last name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter your email")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        [Phone]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please specify if you will attend")]
        public bool? WillAttend { get; set; }
    }
}
