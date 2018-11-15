using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstDemo.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        public string CourseName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}