using System;

namespace CivSportsResultExample_20210610.models
{
    public class SportResult
    {
        public string Location { get; set; }
        public DateTime Time { get; set; }

        public SportResult(string location, DateTime time)
        {
            this.Location = location;
            this.Time = time;
        }
    }
}