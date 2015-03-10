using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingAdsDb;

namespace _06.SelectCertainColumn
{
    class SelectCertainColumn
    {
        static void Main(string[] args)
        {
            var db = new AdsEntities();

            // the following statement causes
            // the application to connect to the database
            // and we need this in order to measure 
            // the select accurately
            Console.WriteLine(db.Ads.Count());

            var start = DateTime.Now;
            var adTitles = db.Ads.Select(a => a.Title);

            foreach (var title in adTitles)
            {
                Console.WriteLine(title);
            }

            Console.WriteLine("\nElapsed: {0}", DateTime.Now - start);

        }
    }
}
