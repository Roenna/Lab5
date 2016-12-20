using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MilenaŁukasikLab5.Models
{
    public class EfDbContext : DbContext
    {
        public virtual IDbSet<Student> Students { get; set; }
        public virtual IDbSet<Grade> Grades { get; set; }

    }
}