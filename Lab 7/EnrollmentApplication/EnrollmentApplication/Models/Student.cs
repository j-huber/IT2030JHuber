using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Student : IValidatableObject
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

        [MinimumAge(20)]
        public virtual int Age { get; set; }

        public virtual string Address1 { get; set; }

        public virtual string Address2 { get; set; }

        public virtual string City { get; set; }

        public virtual string Zipcode { get; set; }

        public virtual string State { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //validate address
            if (Address1.Equals(Address2))
            {
                yield return (new ValidationResult("Address 1 cannot be the same as Address 2"));
            }

            //validate state minimum
            if (State.Length != 2)
            {
                yield return (new ValidationResult("Enter a 2 digit State Code"));
            }

             //validate zipcode
            if (Zipcode.Length != 5)
            {
                yield return (new ValidationResult("Enter a 5 digit Zipcode"));
            }
            
        }
    }
}