using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Жестокие_Игры
{
    public class Player
    {
        public int playerId { get; set; }  // user counter 
        public String name { get; set; }
        public int points { get; set; }

        public Player(int playerId, string name, int points)
        {
            this.playerId = playerId;
            this.name = name;
            this.points = points;
        }
    }
}
