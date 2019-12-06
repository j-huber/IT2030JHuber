using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FinalProject_JasonHuber.Models
{
    public class Event
    {
        [Key]
        public virtual int EventId { get; set; }

        [Required]
        [StringLength(50), MinLength(1)]
        public virtual string EventTitle { get; set; }
        [Required]
        [StringLength(150), MinLength(1)]
        public virtual string EventDescription { get; set; }
        [Required]
        public virtual DateTime EventStartDate { get; set; }
        [Required]
        public virtual DateTime EventEndDate { get; set; }

        [Required]
        public virtual string EventStartTime { get; set; }


        [Required]
        public virtual string EventEndTime { get; set; }
        public virtual EventType EventType { get; set; }

        [Required]
        public virtual string EventCity { get; set; }
        [Required]
        public virtual string EventState { get; set; }


        [Required]
        public virtual string OrganizerName { get; set; }

        public virtual string OrganizerPhoneNumber { get; set; }

        public virtual string OrganizerEmail { get; set; }
        

        [Required]
        
        public virtual int MaxTickets { get; set; }
        [Required]

        public virtual int TicketsAvailable { get; set; }


    }
}