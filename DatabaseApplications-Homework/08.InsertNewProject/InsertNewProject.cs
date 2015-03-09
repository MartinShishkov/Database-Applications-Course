using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingSoftuniDb;

namespace _08.InsertNewProject
{
    class InsertNewProject
    {
        static void Main(string[] args)
        {
            Project newProject = new Project()
            {
                Name = "The newest project yet",
                StartDate = new DateTime(2015, 2, 14),
                Description = "This project started on Valentine's Day!"
            };

            Employee emp1 = new Employee()
            {
                FirstName = "Valentin",
                LastName = "Valev",
                JobTitle = "C# Developer",
                Salary = 3000,
                HireDate = new DateTime(2014, 12, 26),
                DepartmentID = 3
            };

            Employee emp2 = new Employee()
            {
                FirstName = "Tanya",
                LastName = "Petkova",
                JobTitle = "Web Consultant",
                Salary = 3200,
                HireDate = new DateTime(2014, 10, 10),
                DepartmentID = 6
            };

            newProject.Employees.Add(emp1);
            newProject.Employees.Add(emp2);

            SoftUniEntities db = new SoftUniEntities();
            using (db)
            {
                db.Projects.Add(newProject);
                db.SaveChanges();
            }

        }
    }
}
