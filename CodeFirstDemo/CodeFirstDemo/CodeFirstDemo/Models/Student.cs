using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstDemo.Models
{
    
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        public int DistrictId { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Birthday { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [EmailAddress]
       
        public string Email { get; set; }
        [Required]
        [MinLength(9), MaxLength(20)]
        public string Phone { get; set; }
        [Required]
        public District District { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}