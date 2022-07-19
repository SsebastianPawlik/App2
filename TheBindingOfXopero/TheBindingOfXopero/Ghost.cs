using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheBindingOfXopero
{
    internal class Ghost : Enemy
    {
        public Ghost(Game game, Point location) : base(game, location, 8) { }

        public override void Move(Random random)
        {
            if (!Dead)
            {
                if (random.Next(3) == 1) 
                    location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundries);
                if (NearPlayer())
                    game.HitPlayer(3, random);
            }
        }
    }
}
