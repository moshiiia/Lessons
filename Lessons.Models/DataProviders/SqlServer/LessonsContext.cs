using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lessons.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lessons.Models.DataProviders.SqlServer
{
    public class LessonsContext:DbContext
    {
        public DbSet<Student> Students { get; set; } = null!;
       public DbSet<Course> Courses { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder mb) 
        {
            mb.Entity<Student>().HasKey(s => s.Id);
            mb.Entity<Course>().HasKey(c => c.Id);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("Data Source=DBSRV\\MSSQL2021;Initial Catalog=LessonsTAS;Integrated Security=True");
        }
    }
}
