using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionProcessing.Models
{
    public class LoginUser
    {
        // No other fields!
        [Display(Name = "Email:")]
        [Required]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [Display(Name = "Password:")]
        [MinLength(8, ErrorMessage = "Password must be 8 characters or longer!")]
        public string Password { get; set; }
    }
}
