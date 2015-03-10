using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingAdsDb;

namespace _02.ShowRelatedTableData_Fast
{
    class ShowRelatedTableData_Fast
    {
        static void Main(string[] args)
        {
            var db = new AdsEntities();

            foreach (var ad in db.Ads
                .Include(a => a.AdStatus)
                .Include(a => a.Category)
                .Include(a => a.Town)
                .Include(a => a.AspNetUser))
            {
                Console.WriteLine("{0}", ad.Title);
                Console.WriteLine("\t{0}", ad.AdStatus.Status);

                if (ad.Category != null) Console.WriteLine("\t{0}", ad.Category.Name);
                if(ad.Town != null) Console.WriteLine("\t{0}", ad.Town.Name);

                Console.WriteLine("\t{0}", ad.AspNetUser.Name);
            }

        }
    }
}
