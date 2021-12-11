using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Team4_FinalProject.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 1)]
        [RegularExpression("^[a-zA-Z0-9]+$", ErrorMessage = "Username may not contain special characters.")]
        public string Username { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 8)]
        [RegularExpression("^[a-zA-Z0-9!@#$&()\\-`.+,/\"]*$", ErrorMessage = "Password must be 8 characters long")]
        public string Password { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 1)]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "First name may not contain special characters or numbers.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 1)]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Last name may not contain special characters or numbers.")]
        public string LastName { get; set; }
        
        [Required]
        public bool IsTechnician { get; set; }
    }
}
