using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBindingOfXopero
{
    internal class Game
    {
        public IEnumerable<Enemy> Enemies { get; private set; }
        public Weapon WeaponInRoom { get; private set; }

        private Player player;
        public Point PlayerLocation { get { return player.Location; } }
        public int PlayerHitPoints { get { return player.HitPoints; } }
        public IEnumerable<string> PlayerWeapons { get { return player.Weapons; } }
        private int level = 0;
        public int Level { get { return level; } }

        private Rectangle boundries;
        public Rectangle Boundries { get { return boundries; } }

        public Game(Rectangle boundries)
        {
            this.boundries = boundries;
            player = new Player(this, new Point(boundries.Left + 10, boundries.Top + 70));
        }

        public void Move(Direction direction, Random random)
        {
            player.Move(direction);
            foreach (Enemy enemy in Enemies)
                enemy.Move(random);
        }

        public void Equip(string weaponName)
        {
            player.Equip(weaponName);
        }

        public bool CheckPlayerInventory(string weaponName)
        {
            return player.Weapons.Contains(weaponName);
        }

        public void HitPlayer(int maxDamage, Random random)
        {
            player.Hit(maxDamage, random);
        }

        public void IncreasePlayerHealth(int health, Random random)
        {
            player.IncreaseHealth(health, random);
        }

        public void Attack(Direction direction, Random random)
        {
            player.Attack(direction, random);
            foreach (Enemy enemy in Enemies)
            {
                enemy.Move(random);
            }
        }

        private Point GetRandomLocation(Random random)
        {
            return new Point(boundries.Left + random.Next(boundries.Right / 10 - boundries.Left / 10) * 10, boundries.Top + random.Next(boundries.Bottom / 10 - boundries.Top / 10) * 10);
        }

        public void NewLevel(Random random)
        {
            level++;
            switch (level)
            {
                case 1:
                    Enemies = new List<Enemy>() { new Bat(this, GetRandomLocation(random)), };
                    WeaponInRoom = new Sword(this, GetRandomLocation(random));
                    break;
                case 2:
                    Enemies = new List<Enemy>() { new Ghost(this, GetRandomLocation(random)), };
                    WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    break;
                case 3:
                    Enemies = new List<Enemy>() { new Ghoul(this, GetRandomLocation(random)), };
                    WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    break;
                case 4:
                    Enemies = new List<Enemy>()
                    {
                        new Bat(this,GetRandomLocation(random)),
                        new Ghost(this,GetRandomLocation(random)),
                    };
                    if (CheckPlayerInventory("Bow"))
                    {
                        if (!CheckPlayerInventory("Blue Potion"))
                            WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    }
                    else
                    {
                        WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    }
                    break;
                case 5:
                    Enemies = new List<Enemy>()
                    {
                        new Bat(this,GetRandomLocation(random)),
                        new Ghoul(this,GetRandomLocation(random)),
                    };
                    WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                    break;
                case 6:
                    Enemies = new List<Enemy>()
                    {
                        new Ghost(this,GetRandomLocation(random)),
                        new Ghoul(this,GetRandomLocation(random)),
                    };
                    WeaponInRoom = new Maczuga(this, GetRandomLocation(random));
                    break;
                case 7:
                    Enemies = new List<Enemy>()
                    {
                        new Bat(this,GetRandomLocation(random)),
                        new Ghost(this,GetRandomLocation(random)),
                        new Ghoul(this,GetRandomLocation(random)),
                    };
                    if (CheckPlayerInventory("Mace"))
                    {
                        if (!CheckPlayerInventory("Red Potion"))
                            WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    }
                    else
                    {
                        WeaponInRoom = new Maczuga(this, GetRandomLocation(random));
                    }
                    break;
                case 8:
                    Application.Exit();
                    break;
            }
        }
    }
}
