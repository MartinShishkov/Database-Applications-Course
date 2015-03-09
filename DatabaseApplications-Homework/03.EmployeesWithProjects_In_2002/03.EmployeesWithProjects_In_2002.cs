using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingSoftuniDb;

namespace _03.EmployeesWithProjects_In_2002
{
    class EmployeesWithProjectsIn2002
    {
        static void Main(string[] args)
        {
            SoftUniEntities db = new SoftUniEntities();

            using (db)
            {
                var employees = db.Employees.ToList()
                .Where(
                    e => e.Projects.ToList()
                        .Any(p => p.StartDate.Year == 2002)
                );

                foreach (var employee in employees)
                {
                    Console.WriteLine("{0} {1}", employee.FirstName, employee.LastName);
                }
            }
        }
    }
}
