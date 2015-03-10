using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingAdsDb;

namespace _01.ShowRelatedTableData_Slow
{
    class ShowRelatedTableData_Slow
    {
        static void Main(string[] args)
        {
            var db = new AdsEntities();
            var ads = db.Ads.ToList();

            foreach (var ad in ads)
            {
                Console.WriteLine("{0}", ad.Title);
                Console.WriteLine("\t{0}", ad.AdStatus.Status);

                if (ad.Category != null) Console.WriteLine("\t{0}", ad.Category.Name);
                if (ad.Town != null) Console.WriteLine("\t{0}", ad.Town.Name);

                Console.WriteLine("\t{0}", ad.AspNetUser.Name);
            }
        }
    }
}
