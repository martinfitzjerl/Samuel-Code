/*using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Text.RegularExpressions;

namespace WebApp.Mvc.Models.Filters
{
    public class CustomValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            //return base.IsValid(value);

            if (Regex.IsMatch(value.ToString(), "[a-zA-Z0-9]")) ;
        }
    }
}
*/