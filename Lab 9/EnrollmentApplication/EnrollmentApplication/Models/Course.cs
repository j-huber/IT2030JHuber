using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Course : IValidatableObject
    {
        [Display(Name = "Course ID")]
        public virtual int CourseID { get; set; }

        [Required]
        [StringLength(150, ErrorMessage ="The course title you entered is too long.")]
        [Display(Name = "Course Title")]
        public virtual string CourseTitle { get; set; }

        
        [Display(Name = "Description")]
        public virtual string CourseDescription { get; set; }

        [Required]
        [Range(1,4, ErrorMessage ="Please enter a number of credits between 1 and 4.")]
        [Display(Name = "Number of Credits")]
        public virtual int CourseCredits { get; set; }

        public virtual string InstructorName { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // validation for credits 1-4
            if (CourseCredits < 1 || CourseCredits > 4)
            {
                yield return (new ValidationResult("Credits must be between 1 and 4"));
            }
            
            //validation for description being too long
            if (CourseDescription.Split(' ').Length > 100)
            {
                yield return (new ValidationResult("Your description is too verbose"));
            }

            
        }
    }
}