using System;

namespace CivSportsResultExample_20210610.models
{
    public class Player
    {
        public string FName { get; set; }
        public string SName { get; set; }

        public Player(string fName, string sName)
        {
            this.FName = fName;
            this.SName = sName;
        }
    }
}