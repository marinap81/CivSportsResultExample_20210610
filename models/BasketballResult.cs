using System;

namespace CivSportsResultExample_20210610.models
{
    public class BasketballResult : SportResult
    {
 

        public int PointsTeamA { get; set; }
        public int PointsTeamB { get; set; }
        public Team TeamA { get; set; }
        public Team TeamB { get; set; }

        public BasketballResult(string location, DateTime time, int pointsTeamA, 
                    int pointsTeamB, Team teamA, Team teamB) : base(location, time)
        {
            this.PointsTeamA = pointsTeamA;
            this.PointsTeamB = pointsTeamB;
            this.TeamA = teamA;
            this.TeamB = teamB;
        }

        public Team GetWinner() {
            if (PointsTeamA > PointsTeamB) {
                return TeamA;
            }
            return TeamB;
        }

        public string GetWinnerName() {
            if (PointsTeamA > PointsTeamB) {
                return TeamA.Name;
            }
            return TeamB.Name;
        }

    }
}