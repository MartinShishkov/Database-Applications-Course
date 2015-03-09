using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingSoftuniDb;

namespace _09.CallStoredProcedure
{
    class CallStoredProcedure
    {
        static void Main(string[] args)
        {
            SoftUniEntities db = new SoftUniEntities();
            var firstName = "Peng";
            var lastName = "Wu";

            var result = db.usp_GetEmployeeProjectCount(firstName, lastName);
            Console.WriteLine("Projects for {0} {1} - {2}", firstName, lastName, result.FirstOrDefault());
        }
    }
}
