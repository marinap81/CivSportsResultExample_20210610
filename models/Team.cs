using System.Collections.Generic;

namespace CivSportsResultExample_20210610.models
{
    public class Team
    {
        public string Name { get; set; }
        public List<Player> Players { get; set; }

        public Team(string name, List<Player> players)
        {
            this.Name = name;
            this.Players = players;
        }
        
    }
}