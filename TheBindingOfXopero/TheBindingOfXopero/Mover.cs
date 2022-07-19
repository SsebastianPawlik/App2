using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBindingOfXopero
{
    abstract class Mover
    {
        private const int MoveInterval = 10;
        protected Point location;
        public Point Location { get { return location; } }
        protected Game game;

        public Mover(Game game, Point location)
        {
            this.game = game;
            this.location = location;
        }

        public bool Nearby(Point locationToCheck, int distance)
        {
            Point targetLocation = Location; 
            if (Math.Abs(targetLocation.X - locationToCheck.X) < distance && (Math.Abs(targetLocation.Y - locationToCheck.Y) < distance))
            {
                return true;
            }
            else
                return false;
        }

        public bool Nearby(Point locationToCheck, Point target, int distance)
        {
            location = target;
            return Nearby(locationToCheck, distance);
        }

        public Point Move(Direction direction, Rectangle boundries)
        {
            Point newLocation = location;
            switch (direction)
            {
                case Direction.Up:
                    if (newLocation.Y - MoveInterval >= boundries.Top)
                        newLocation.Y -= MoveInterval;
                    break;
                case Direction.Down:
                    if (newLocation.Y + MoveInterval <= boundries.Bottom)
                        newLocation.Y += MoveInterval;
                    break;
                case Direction.Left:
                    if (newLocation.X - MoveInterval >= boundries.Left)
                        newLocation.X -= MoveInterval;
                    break;
                case Direction.Right:
                    if (newLocation.X + MoveInterval <= boundries.Right)
                        newLocation.X += MoveInterval;
                    break;
                default: break;
            }
            return newLocation;
        }

        public Point Move(Direction direction, Point target, Rectangle boundries)
        {
            location = target;
            return Move(direction, boundries);
        }
    }
}
