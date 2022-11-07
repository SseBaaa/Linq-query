using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_query
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> studentList = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "John" },
                new Student() { StudentID = 2, StudentName = "Moin" },
                new Student() { StudentID = 3, StudentName = "Bill" },
                new Student() { StudentID = 4, StudentName = "Ram" },
                new Student() { StudentID = 5, StudentName = "Ron" }
            };

            var mysql = from s in studentList
                        where s.StudentID == 1
                        select s;


            foreach (var s in mysql)
            {
                Console.WriteLine(s.StudentName);
            }
            Console.ReadKey();
        }

        public class Student
        {

            public int StudentID { get; set; }
            public string StudentName { get; set; }
        }
    }

}
