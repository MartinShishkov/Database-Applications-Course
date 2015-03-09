using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingSoftuniDb;

namespace _06.ConcurrentDatabaseChanges
{
    class ConcurrentDatabaseChanges
    {
        static void Main(string[] args)
        {
            SoftUniEntities db1 = new SoftUniEntities();
            SoftUniEntities db2 = new SoftUniEntities();

            using (db1)
            {
                using (db2)
                {
                    var employee2 = db2.Employees.ToList().FirstOrDefault();
                    if (employee2 != null) employee2.FirstName = "Batgergi";

                    var employee = db1.Employees.ToList().FirstOrDefault();
                    if (employee != null) employee.FirstName = "Sashko";

                    db2.SaveChanges();
                    db1.SaveChanges();
                }

                var emp = db1.Employees.ToList().FirstOrDefault();
                Console.WriteLine("{0}", emp.FirstName);
            }

        }
    }
}
