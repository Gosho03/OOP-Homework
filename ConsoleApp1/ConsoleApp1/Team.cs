using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   public class Team
    {
        int totalAge = 0;
        public Coach Coach { get; set; }
        public List<FootballPlayer> players { get; set; }
        public double AvgAge()
        {           
            foreach(var player in players)
            {
                totalAge += player.Age;
            }
            double averageAge = totalAge / players.Count;
            return averageAge;
        }
    }
}
