using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ProgramStudent
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string Major { get; set; }
        [Required]
        [MaxLength(30)]
        public string College { get; set; }
        [Required]
        [MaxLength(30)]
        public int GradYear { get; set; }
        [Required]
        public bool GradWithHonors { get; set; }
        [Required]
        public bool AlumniDonor { get; set; }
    }


}
