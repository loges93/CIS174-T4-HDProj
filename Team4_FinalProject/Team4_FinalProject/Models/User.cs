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
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Username must be between 5 and 20 characters")]
        [RegularExpression("^[a-zA-Z0-9", ErrorMessage = "Username cannot contain any special characters")]
        public string Username { get; set; }
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Created password must be between 8 and 20 characters long")]
        [RegularExpression("^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]$", ErrorMessage = "Created password must be 8 characters long with at least 1 letter and 1 number")]
        public string Password { get; set; }
        [StringLength(25, ErrorMessage = "First name must be 25 or fewer characters long")]
        [RegularExpression("^[a-zA-Z", ErrorMessage = "First name cannot contain numbers or special characters")]
        public string FirstName { get; set; }
        [StringLength(25, ErrorMessage = "Last name must be 25 or fewer characters long")]
        [RegularExpression("^[a-zA-Z", ErrorMessage = "Last name cannot contain numbers or special characters")]
        public string LastName { get; set; }
        public bool IsTechnician { get; set; }

        public List<Ticket> Tickets { get; set; }
    }
}
