using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerJoin
{
    public class StudentCourse
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string CourseName { get; set; }
        public int Score { get; set; }

        public static List<StudentCourse> GetListOfStudentCourses() =>
            new List<StudentCourse>()
            {
                new StudentCourse()
                {
                    Id = 1,
                    StudentId = 1,
                    CourseName = "ASP.NET Core",
                    Score = 20
                },
                new StudentCourse()
                {
                    Id = 2,
                    StudentId = 1,
                    CourseName = "SQL Serve",
                    Score = 18
                },
                new StudentCourse()
                {
                    Id = 3,
                    StudentId = 2,
                    CourseName = "Angular",
                    Score = 15
                },
                new StudentCourse()
                {
                    Id = 4,
                    StudentId = 3,
                    CourseName = "Vue JS",
                    Score = 11
                },
                new StudentCourse()
                {
                    Id = 5,
                    StudentId = 3,
                    CourseName = "ASP.NET Core",
                    Score = 13
                },
                new StudentCourse()
                {
                    Id = 6,
                    StudentId = 3,
                    CourseName = "Mongo DB",
                    Score = 12
                },
            };
    }
}
