using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstDemo.Models
{
    public class District
    {
        public int Id { get; set; }
        [Required]
        public string DistrictName { get; set; }
        public string Note { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}