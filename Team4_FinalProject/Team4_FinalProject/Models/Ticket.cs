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

        public string Category { get; set; }

        public DateTime DateOpened = DateTime.Now;

        public string Status { get; set; }

        public List<Note> Notes { get; set; }

        //Establishing Many to One with user
        public int UserId { get; set; }
        public User  User { get; set; }


    }
}
