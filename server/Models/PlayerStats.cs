using System;

namespace server
{
    public class PlayerStats
    {
        public int id { get; set; }
        public string name { get; set; }
        public int PassingAttempts { get; set; }
        public int PassingCompletions { get; set; }
        public int PassingYards { get; set; }
        public int PassingTouchdowns { get; set; } 

    }
}