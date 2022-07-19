using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheBindingOfXopero
{
    internal class Maczuga : Weapon
    {
        public Maczuga(Game game, Point location) : base(game, location) { }

        public override string Name { get { return "Maczuga"; } }

        public override void Attack(Direction direction, Random random)
        {
            DamageEnemy(Direction.Right, 20, 6, random);
            DamageEnemy(Direction.Up, 20, 6, random);
            DamageEnemy(Direction.Left, 20, 6, random);
            DamageEnemy(Direction.Down, 20, 6, random);
        }
    }
}
