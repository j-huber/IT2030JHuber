using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject_JasonHuber.Models
{
    public class EventType
    {
        [Key]
        public virtual int EventTypeId { get; set; }
        public virtual string EventTypeName { get; set; }
    }
}