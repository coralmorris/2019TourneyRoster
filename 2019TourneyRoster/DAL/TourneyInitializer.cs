using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using _2019TourneyRoster.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace _2019TourneyRoster.DAL
{
    public class TourneyInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TourneyContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TourneyContext>>()))
            {
                // Look for any team.
                if (context.Teams.Any())
                {
                    return;   // DB has been seeded
                }

                context.Teams.AddRange(
                    new Team
                    {
                        Name = "Black"
                    },
                    new Team
                    {
                        Name = "Red"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
