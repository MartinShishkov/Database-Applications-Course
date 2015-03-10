using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingAdsDb;

namespace _05.SelectAll
{
    class SelectAll
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
            var ads = db.Ads;

            foreach (var ad in ads)
            {
                Console.WriteLine(ad.Title);
            }

            Console.WriteLine("\nElapsed: {0}", DateTime.Now - start);
        }
    }
}
