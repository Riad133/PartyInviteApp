using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartInvitesApp.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your email.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter valid email.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone no.")]
        public string PhoneNo { get; set; }
        [Required(ErrorMessage = "Are you attend?")]
        public bool WillAttend { get; set; }
    }
}