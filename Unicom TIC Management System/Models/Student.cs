﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC_Management_System.Models
{
    public class Student
    {
        public int StudentID { get; set; }       
        public string Name { get; set; }       
        public int CourseID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }

    }
}