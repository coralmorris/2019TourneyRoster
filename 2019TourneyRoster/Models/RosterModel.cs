using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using _2019TourneyRoster.DAL;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace _2019TourneyRoster.Models
{
    public class RosterModel
    {
        public RosterModel()
        {
        }
        public IList<Player> RedTeam { get; set; }
        public IList<Player> BlackTeam { get; set; }
        public IList<Team> Teams { get; set; }
    }
}
