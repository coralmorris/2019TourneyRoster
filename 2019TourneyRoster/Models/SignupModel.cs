using System;
namespace _2019TourneyRoster.Models
{
    public class PlayerViewModel
    {
        public PlayerViewModel()
        {
        }

        public int PlayerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ShirtSize { get; set; }
        public string TeamName { get; set; }
    }
}
