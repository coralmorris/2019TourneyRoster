using System;
using System.Collections.Generic;

namespace _2019TourneyRoster.Models
{
    public class TeamRoster
    {
        public TeamRoster()
        {
        }

        public int ID { get; set; }
        public int TeamID { get; set; }
        public int PlayerID { get; set; }

        public virtual ICollection<Player> Players { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
