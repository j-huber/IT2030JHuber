using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Student
    {
        [Display(Name ="Student ID")]
        public virtual int StudentID { get; set; }

        [Required]
        [StringLength(50, ErrorMessage ="The last name you entered is too long.")]
        [Display(Name ="Last Name")]
        public virtual string StudentLastName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage ="The first name you entered is too long.")]
        [Display(Name = "First Name")]
        public virtual string StudentFirstName { get; set; }
    }
}