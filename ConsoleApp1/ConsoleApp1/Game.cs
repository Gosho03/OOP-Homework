using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Game
    {
        public Team TeamHome { get; set; }
        public Team TeamAway { get; set; }
        public Referee Referee { get; set; }
        public List<Referee> AssistantReferees { get; set; }
        public string Resukt { get; set; }
        public Team Winner { get; set; }
    }
}
