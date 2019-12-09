using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using FinalProject_JasonHuber.Models;

namespace FinalProject_JasonHuber.Models
{
    public class Order
    {
        [Key]
        public int EventId { get; set; }
        public string OrderId { get; set; }
        public virtual Event EventSelected { get; set; }
        public int TicketCount { get; set; }
        public DateTime DateCreated { get; set; }
    }
}