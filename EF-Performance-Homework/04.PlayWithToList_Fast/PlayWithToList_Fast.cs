using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingAdsDb;

namespace _04.PlayWithToList_Fast
{
    class PlayWithToList_Fast
    {
        static void Main(string[] args)
        {
            var db = new AdsEntities();

            //var start = DateTime.Now;
            //var ads = db.Ads
            //    .OrderBy(a => a.Date)
            //    .Where(a => a.AdStatus.Status.Equals("Published"))
            //    .Select(a => new
            //    {
            //        Title = a.Title,
            //        Town = a.Town.Name,
            //        Category = a.Category.Name
            //    })
            //    .ToList();
            
            //Console.WriteLine("Elapsed: {0}", DateTime.Now - start);




        }
    }
}
