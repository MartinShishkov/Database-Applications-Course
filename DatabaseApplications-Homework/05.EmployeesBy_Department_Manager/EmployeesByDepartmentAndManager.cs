using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingSoftuniDb;

namespace _05.EmployeesBy_Department_Manager
{
    class EmployeesByDepartmentAndManager
    {
        static void Main(string[] args)
        {
            SoftUniEntities db = new SoftUniEntities();

            string departmentName;
            string managerFirstName;
            string managerLastName;

            // Department -> Marketing
            // FirstName -> David
            // LastName -> Bradley

            Console.Write("Department: ");
            departmentName = Console.ReadLine();

            Console.Write("Manager First Name: ");
            managerFirstName = Console.ReadLine();

            Console.Write("Manager Last Name: ");
            managerLastName = Console.ReadLine();

            using (db)
            {
                var employees = db.Employees.ToList()
                .Where(e => 
                        e.Department.Name.Equals(departmentName) &&
                        e.Employee1.FirstName.Equals(managerFirstName) &&
                        e.Employee1.LastName.Equals(managerLastName));

                foreach (var employee in employees)
                {
                    Console.WriteLine("{0} {1} - {2}", 
                        employee.FirstName, employee.LastName, employee.Salary);
                }
            }
        }
    }
}
