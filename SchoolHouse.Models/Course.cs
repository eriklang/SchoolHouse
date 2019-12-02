using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolHouse.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }

        public int DepartmentID { get; set; }  // Biology
        public string Name { get; set; }        //  Intro Into Biology
        public int Section { get; set; }        // 101
        public string Description { get; set; }

    }
}
