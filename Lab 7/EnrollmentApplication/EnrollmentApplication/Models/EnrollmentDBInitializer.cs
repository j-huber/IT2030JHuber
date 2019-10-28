using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models
{
    public class EnrollmentDBInitializer : System.Data.Entity.DropCreateDatabaseAlways<EnrollmentDB>
    {
        protected override void Seed(EnrollmentDB context)
        {
            context.Courses.Add(new Course { CourseTitle = "English", CourseCredits = 3, CourseDescription = "English w Honors", CourseID = 1 });
            context.Courses.Add(new Course { CourseTitle = "Math", CourseCredits = 3, CourseDescription = "Math w Honors", CourseID = 2 });
            context.Courses.Add(new Course { CourseTitle = "Science", CourseCredits = 3, CourseDescription = "Science w Honors", CourseID = 3});
            context.Courses.Add(new Course { CourseTitle = "History", CourseCredits = 3, CourseDescription = "History w Honors", CourseID = 4 });
            context.Courses.Add(new Course { CourseTitle = "Philosophy", CourseCredits = 3, CourseDescription = "Philosophy w Honors", CourseID = 5 });
           context.Students.Add(new Student { StudentID = 1, StudentFirstName = "Jason", StudentLastName = "Huber" });
            context.Students.Add(new Student { StudentID = 2, StudentFirstName = "Joseph", StudentLastName = "Hocevar" });
            context.Students.Add(new Student { StudentID = 3, StudentFirstName = "Alice", StudentLastName = "Smith" });
            context.Students.Add(new Student { StudentID = 4, StudentFirstName = "Alex", StudentLastName = "Gonzalez" });
           context.Students.Add(new Student { StudentID = 5, StudentFirstName = "Ryan", StudentLastName = "Splitt" });

            base.Seed(context);
        }
    }
}