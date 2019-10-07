using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Enrollment
    {
        public virtual int EnrollmentID { get; set; }
        public virtual int StudentID { get; set; }
        public virtual int CourseID { get; set; }

        [Required]
        [RegularExpression(@"[A-F]", ErrorMessage = "Please enter a valid grade of A-F.")]
        public virtual char Grade { get; set; }
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
        public virtual bool IsActive { get; set; }

        [Required(ErrorMessage ="Your Campus is required.")]
        [Display(Name = "Assigned Campus")]
        public virtual string AssignedCampus { get; set; }

        [Required (ErrorMessage ="Your Semester is required.")]
        [Display(Name = "Enrolled in Semester")]
        public virtual string EnrollmentSemester { get; set; }

        [Required]
        [Range(2018, 9999, ErrorMessage ="The year entered cannot be before than 2018.")]
        public virtual int EnrollmentYear { get; set; }
    }
}