using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MilenaŁukasikLab5.Models
{
    public class Student : ModelBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Index { get; set; }
        public IList<Grade> Grades { get; set; }
    }
}