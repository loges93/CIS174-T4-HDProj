using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team4_FinalProject.Models
{
    public class TicketNoteViewModel
    {
        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<Note> Notes { get; set; }
    }
}
