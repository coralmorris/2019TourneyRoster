using System;
using System.Threading.Tasks;
using _2019TourneyRoster.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _2019TourneyRoster.Models
{
    public class SignupModel
    {
        public SignupModel()
        {
        }

        public Player Player { get; set; }
    }
}
