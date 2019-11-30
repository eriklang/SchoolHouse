using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolHouse.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Display(Name = "Date Of Birth")]
        public DateTime? DOB { get; set; }
    }
}
