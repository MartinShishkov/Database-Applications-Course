using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingSoftuniDb;

namespace _02.DAO_Class
{
    /// <summary>
    /// All methods return boolean value indicating 
    /// whether or not any changes have been made.
    /// </summary>
    public static class DAO
    {
        public static bool InsertEmployee(string firstName, string lastName, string jobTitle, int departmentId,
            DateTime hireDate, decimal salary)
        {
            SoftUniEntities db = new SoftUniEntities();

            using (db)
            {
                var employee = new Employee();
                employee.FirstName = firstName;
                employee.LastName = lastName;
                employee.JobTitle = jobTitle;
                employee.DepartmentID = departmentId;
                employee.HireDate = hireDate;
                employee.Salary = salary;

                db.Employees.Add(employee);
                return db.SaveChanges() > 0;
            }
        }

        public static bool DeleteEmployee(int employeeId)
        {
            SoftUniEntities db = new SoftUniEntities();

            using (db)
            {
                var employee = db.Employees.FirstOrDefault(e => e.EmployeeID == employeeId);

                db.Employees.Remove(employee);
                return db.SaveChanges() > 0;
            }
        }

        public static bool DeleteEmployee(string firstName)
        {
            SoftUniEntities db = new SoftUniEntities();

            using (db)
            {
                var employee = db.Employees.FirstOrDefault(e => e.FirstName.Equals(firstName));

                db.Employees.Remove(employee);
                return db.SaveChanges() > 0;
            }
        }

        public static bool ModifyEmployee(int employeeId, string newFirstName)
        {
            SoftUniEntities db = new SoftUniEntities();

            using (db)
            {
                var employee = db.Employees.FirstOrDefault(e => e.EmployeeID == employeeId);
                if (employee != null)
                {
                    employee.FirstName = newFirstName;
                }

                return db.SaveChanges() > 0;
            }
        }
    }
}
