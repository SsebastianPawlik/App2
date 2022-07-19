using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheBindingOfXopero
{
    internal class Bat : Enemy
    {
        public Bat(Game game, Point location) : base(game, location, 6) { }

        public override void Move(Random random)
        {
            if (!Dead)
            {
                Direction directionToMove;
                if (random.Next(2) == 1)
                    directionToMove = FindPlayerDirection(game.PlayerLocation);
                else
                    directionToMove = (Direction)random.Next(4);
                location = Move(directionToMove, game.Boundries);
                if (NearPlayer())
                {
                    game.HitPlayer(2, random);
                }
            }
        }
    }
}
