using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDbContext db = new StudentDbContext();
            Student[] students = db.Students.ToArray();
            foreach(Student stud in students)
            {
                string message = $"Id={stud.Id}, Name={stud.Name}, Major={stud.Major}, College={stud.College}, GradYear={stud.GradYear}, GradWithHonors={stud.GradWithHonors}, AlumniDonor={stud.AlumniDonor}";
                Console.WriteLine(message);
            }
            Console.ReadKey();
        }
    }
}
