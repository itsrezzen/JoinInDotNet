using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerJoin
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }

        public static List<Student> GetListOfStudents() =>
            new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    FirstName = "James",
                    LastName = "Johnson",
                    Grade = 10
                },
                new Student()
                {
                    Id = 2,
                    FirstName = "Thomas",
                    LastName = "Smith",
                    Grade = 11
                },
                new Student()
                {
                    Id = 3,
                    FirstName = "Jack",
                    LastName = "Davis",
                    Grade = 9
                },
            };
    }
}
