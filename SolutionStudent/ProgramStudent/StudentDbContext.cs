using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ProgramStudent
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext() : base()
        {
        }
        public virtual DbSet<Student> Student { get; set; }
    }
}
