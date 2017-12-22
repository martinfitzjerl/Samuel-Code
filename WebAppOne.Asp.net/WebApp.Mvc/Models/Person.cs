using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Mvc.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Connor said so")] //validate on user side for their errors
        //validate on server side for hackers
        [StringLength(50)]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        public string GivenName { get; set; }
        public string Family { get; set; }

        [StringLength(50)]
        public string FamilyName { get; set; }

    }
}