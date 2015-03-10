using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingAdsDb;

namespace _03.PlayWithToList_Slow
{
    class PlayWithToList_Slow
    {
        static void Main(string[] args)
        {
            var db = new AdsEntities();

            var start = DateTime.Now;
            var ads = db.Ads
                .ToList()
                .Where(a => a.AdStatus.Status.Equals("Published"))
                .Select(a => new Ad
                {
                    Title = a.Title,
                    Town = a.Town,
                    Category = a.Category
                })
                .ToList()
                .OrderBy(a => a.Date);

            Console.WriteLine("Elapsed: {0}", DateTime.Now - start);

            //foreach (var ad in ads)
            //{
            //    Console.WriteLine(ad.Title);
            //}

        }
    }
}
