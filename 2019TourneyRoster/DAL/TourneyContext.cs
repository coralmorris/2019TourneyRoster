using System;
using _2019TourneyRoster.Models;
using Microsoft.EntityFrameworkCore;

namespace _2019TourneyRoster.DAL
{
    public class TourneyContext : DbContext
    {
        public TourneyContext(DbContextOptions<TourneyContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
