using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FYPWorkShop
{
    public class StudentContext:DbContext
    {
        public StudentContext():base("StudentString")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}