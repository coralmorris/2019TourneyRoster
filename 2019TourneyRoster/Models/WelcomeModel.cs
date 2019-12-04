using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2019TourneyRoster.DAL;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace _2019TourneyRoster.Models
{
    public class WelcomeModel
    {
        public WelcomeModel()
        {
        }

        public string TeamName { get; set; }
    }
}
