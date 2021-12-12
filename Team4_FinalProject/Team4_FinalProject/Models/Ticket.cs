using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Team4_FinalProject.Models
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }

        [Required(ErrorMessage = "Pleaes enter a category")]
        [StringLength(40, ErrorMessage = "Category must be 40 characters or less.")]
        [RegularExpression("^[a-zA-Z0-9]+$", ErrorMessage = "Name may not contain special characters")]
        public string Category { get; set; }

        public DateTime DateOpened { get; set; }

        public string Status { get; set; }

        //Establishing Many to One with user
        public int UserId { get; set; } //foreign key
        public User User { get; set; }

        //linking notes to tickets
        public ICollection<Note> Notes { get; set; }



}
}
