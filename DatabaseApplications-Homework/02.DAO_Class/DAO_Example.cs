using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingSoftuniDb;

namespace _02.DAO_Class
{
    class DAO_Example
    {
        static void Main(string[] args)
        {
            var insertResult = DAO.InsertEmployee("Edard", "Stark", "C# Developer", 1, DateTime.Now.AddDays(20), 6000);
            Console.WriteLine("Inserted: {0}", insertResult);

            var employeeId = GetLastEmployeeId();
            var deleteResult = DAO.DeleteEmployee(employeeId);
            Console.WriteLine("Deleted: {0}", deleteResult);

            insertResult = DAO.InsertEmployee("Edard", "Stark", "Java Developer", 1, DateTime.Now.AddDays(20), 6000);
            Console.WriteLine("Inserted: {0}", insertResult);

            employeeId = GetLastEmployeeId();
            var modifyResult = DAO.ModifyEmployee(employeeId, "Sansa");
            Console.WriteLine("Modified: {0}", modifyResult);
        }

        private static int GetLastEmployeeId()
        {
            SoftUniEntities db = new SoftUniEntities();
            using (db)
            {
                var employeeId = db.Employees.ToList().Last().EmployeeID;
                return employeeId;
            }
        }
    }
}
