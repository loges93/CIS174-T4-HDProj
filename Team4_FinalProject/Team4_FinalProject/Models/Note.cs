﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Team4_FinalProject.Models
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }

        public DateTime DateCreated { get; set; }

        public string Content { get; set; }

        //Establish Many to One with Ticket
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }

        //used for display in ticket detail display
        public string UserId { get; set; }
        public User User { get; set; }
    }
}