using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2019TourneyRoster.DAL;
using _2019TourneyRoster.Models;
using Microsoft.AspNetCore.Mvc;

namespace _2019TourneyRoster.Controllers
{
    public class PlayerController : Controller
    {
        private readonly TourneyContext _context;

        public PlayerController(TourneyContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Signup()
        {
            return View();
        }

        // GET: /<controller>/welcome
        public IActionResult Welcome()
        {
            return View();
        }

        // Nope, redo, solid
        // POST: /<controller>/
        public async Task<IActionResult> Welcome(SignupModel data)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Signup", data);
            }

            Player player = new Player();
            var team = GetNewPlayerTeam();

            await TryUpdateModelAsync(data);
            player.TeamID = team.ID;

            _context.Players.Add(player);
            _context.SaveChanges();

            var model = new WelcomeModel();
            model.TeamName = team.Name;

            return RedirectToPage("./Welcome", model);
        }

        // can this be broken up 
        public Team GetNewPlayerTeam()
        {
            int playerCount = _context.Players.ToList().Count();
            var teams = _context.Teams.ToList();

            if(playerCount % 2 == 0)
            {
                return teams[0];
            }
            else
            {
                return teams[1];
            }
        }
    }
}
