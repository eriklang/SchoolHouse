using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolHouse.Models
{
    public class Class
    {
        [Key]
        public int ClassID { get; set; }

        public Course Course { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        // Might add marking period or semester
        public Room Room { get; set; }


        public List<Frequency> Frequency { get; set; }


    }
}
