using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team4_FinalProject.Models
{
    public class TicketNoteViewModel
    {
        public IEnumerable<Ticket> Tickets { get; set; }
        public IEnumerable<Note> Notes { get; set; }
    }
}
