using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace RazorPagesMega.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMegaContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMegaContext>>()))
            {
                // Look for any movies.
                if (context.Office.Any())
                {
                    return;   // DB has been seeded
                }

                context.Office.AddRange(
                    new Office
                    {
                        BranchID = 4,
                        OfficeName = "Surabaya Kertajaya",
                        StartDate = DateTime.Parse("1999-8-1")
                    },

                    new Office
                    {
                        BranchID = 5,
                        OfficeName = "Denpasar",
                        StartDate = DateTime.Parse("1989-9-30")
                    },

                    new Office
                    {
                        BranchID = 6,
                        OfficeName = "Jakarta Kota",
                        StartDate = DateTime.Parse("1997-8-8")
                    },

                    new Office
                    {
                        BranchID = 7,
                        OfficeName = "Surabaya Kembang Jepun",
                        StartDate = DateTime.Parse("1969-9-1")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
