using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2019TourneyRoster.DAL;
using _2019TourneyRoster.Models;
using Microsoft.AspNetCore.Mvc;

namespace _2019TourneyRoster.Controllers
{
    public class RosterController : Controller
    {
        private readonly TourneyContext _context;

        public RosterController(TourneyContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult TeamRoster()
        {
            var model = new RosterModel();
            var allPlayers = _context.Players.ToList();
            model.Teams = _context.Teams.ToList();

            var redTeamId = model.Teams.Where(x => x.Name == "Red").FirstOrDefault().ID;
            var blackTeamId = model.Teams.Where(x => x.Name == "Black").FirstOrDefault().ID;

            model.RedTeam = GetTeamList(allPlayers, redTeamId);
            model.BlackTeam = GetTeamList(allPlayers, blackTeamId);

            return View(model);
        }

        public List<Player> GetTeamList(List<Player> roster, int id)
        {
            return roster.Where(x => x.TeamID == id).ToList();
        }
    }
}
