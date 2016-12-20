using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MilenaŁukasikLab5.Models
{
    public class Grade : ModelBase
    {
        public string CourseName { get; set; }
        public decimal Value { get; set; }
        public int Ects { get; set; }
    }
}