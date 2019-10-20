using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentInformationApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string RegNo { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
    }
}