using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingSoftuniDb;

namespace _04.NativeSQL_Query
{
    class NativeSql
    {
        static void Main(string[] args)
        {
            StringBuilder query = new StringBuilder();
            query.Append("SELECT e.FirstName + ' ' + e.LastName \n");
            query.Append("FROM dbo.Employees e \n");
            query.Append("JOIN dbo.EmployeesProjects ep \n");
            query.Append("ON ep.EmployeeID=e.EmployeeID \n");
            query.Append("JOIN dbo.Projects p \n");
            query.Append("ON ep.ProjectID=p.ProjectID \n");
            query.Append("WHERE YEAR(p.StartDate)=2002 \n");
            query.Append("GROUP BY e.FirstName, e.LastName");

            SoftUniEntities db = new SoftUniEntities();

            using (db)
            {
                var employeeNames = db.Database.SqlQuery<string>(query.ToString());

                foreach (var name in employeeNames)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
