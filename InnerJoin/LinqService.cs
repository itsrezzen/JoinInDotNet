using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerJoin
{
    public class LinqService
    {
        public void InnerJoin()
        {
            var listOfStudents = Student.GetListOfStudents();
            var listOfStudentCourses = StudentCourse.GetListOfStudentCourses();

            var result = listOfStudents.Join(listOfStudentCourses, s => s.Id, c => c.StudentId, (s, c) => new
            {
                StudentId = s.Id,
                CourseId = c.Id,
                s.FirstName,
                s.LastName,
                c.CourseName,
                c.Score
            });

            foreach (var item in result)
            {
                Console.WriteLine($"{item.StudentId} : {item.FirstName} - {item.LastName} => {item.CourseName} And Score Is : {item.Score}");
            }
        }
    }
}
