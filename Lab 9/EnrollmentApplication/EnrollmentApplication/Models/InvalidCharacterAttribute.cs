using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class InvalidCharacterAttribute : ValidationAttribute
    {
        readonly string characters;

        public InvalidCharacterAttribute(String characters) : base("{0} Must not include Special Characters ex. *&^%$#@!()[]{} ")
        {
            this.characters = characters;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string Notes = (string) value;
                var NotesArray = Notes.ToCharArray();
                var CharListArray = characters.ToCharArray();
                for (int i = 0; i <= NotesArray.Length; i++)
                {
                    for (int j = 0; j <= CharListArray.Length; j++)
                    {
                        var equals = NotesArray.GetValue(i).Equals(CharListArray.GetValue(j));
                        if (equals == true)
                        {
                            var errormessage = FormatErrorMessage(validationContext.DisplayName);

                            return new ValidationResult(errormessage);
                            
                        }
                    }
                }
            }
            return ValidationResult.Success;
        }
    }
}