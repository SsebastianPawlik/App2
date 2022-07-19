﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheBindingOfXopero
{
    internal class Bow : Weapon
    {
        public Bow(Game game, Point location) : base(game, location) { }

        public override string Name { get { return "Bow"; } }

        public override void Attack(Direction direction, Random random)
        {

            DamageEnemy(direction, 30, 1, random);
        }
    }
}
