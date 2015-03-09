using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSystem.Models;

namespace StudentSystem.Data
{
    public class StudentSystemDbContext : DbContext
    {
        // base(name-of-the-connection-string)
        public StudentSystemDbContext()
            : base("StudentSystem")
        {
            
        }

        public IDbSet<Student> Students { get; set; }

        public IDbSet<Course> Courses { get; set; }

        public IDbSet<Resource> Resources { get; set; }

        public IDbSet<HomeworkSubmission> HomeworkSubmissions { get; set; } 
    }
}
