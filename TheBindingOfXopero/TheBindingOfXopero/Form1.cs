using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TheBindingOfXopero
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
        }

        private void swordClick_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Sword"))
            {
                game.Equip("Sword");
                swordClick.BorderStyle = BorderStyle.FixedSingle;
                bowClick.BorderStyle = BorderStyle.None;
                bluePotionClick.BorderStyle = BorderStyle.None;
                redPotionClick.BorderStyle = BorderStyle.None;
                maczugaClick.BorderStyle = BorderStyle.None;
                UpdateScroll();
            }
        }

        private void maczugaClick_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Maczuga"))
            {
                game.Equip("Maczuga");
                swordClick.BorderStyle = BorderStyle.None;
                bowClick.BorderStyle = BorderStyle.None;
                bluePotionClick.BorderStyle = BorderStyle.None;
                redPotionClick.BorderStyle = BorderStyle.None;
                maczugaClick.BorderStyle = BorderStyle.FixedSingle;
                UpdateScroll();
            }
        }

        private void bowClick_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Bow"))
            {
                game.Equip("Bow");
                swordClick.BorderStyle = BorderStyle.None;
                bowClick.BorderStyle = BorderStyle.FixedSingle;
                bluePotionClick.BorderStyle = BorderStyle.None;
                redPotionClick.BorderStyle = BorderStyle.None;
                maczugaClick.BorderStyle = BorderStyle.None;
                UpdateScroll();
            }
        }

        private void bluePotionClick_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Blue Potion"))
            {
                game.Equip("Blue Potion");
                swordClick.BorderStyle = BorderStyle.None;
                bowClick.BorderStyle = BorderStyle.None;
                bluePotionClick.BorderStyle = BorderStyle.FixedSingle;
                redPotionClick.BorderStyle = BorderStyle.None;
                maczugaClick.BorderStyle = BorderStyle.None;
                UpdateScroll();
            }
        }

        private void redPotionClick_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Red Potion"))
            {
                game.Equip("Red Potion");
                swordClick.BorderStyle = BorderStyle.None;
                bowClick.BorderStyle = BorderStyle.None;
                bluePotionClick.BorderStyle = BorderStyle.None;
                redPotionClick.BorderStyle = BorderStyle.FixedSingle;
                maczugaClick.BorderStyle = BorderStyle.None;
                UpdateScroll();
            }
        }

        private void moveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void moveUp_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void moveRight_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void atackLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }

        private void atackUp_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void atackRight_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        private void atackDown_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();

        }
        public void UpdateScroll()
        {
            if (bluePotionClick.BorderStyle.Equals(BorderStyle.FixedSingle) || redPotionClick.BorderStyle.Equals(BorderStyle.FixedSingle))
            {
                atackDown.Visible = false;
                atackLeft.Visible = false;
                atackRight.Visible = false;
                atackUp.Text = "Wypij";
            }
            else
            {
                atackDown.Visible = true;
                atackLeft.Visible = true;
                atackRight.Visible = true;
                atackUp.Text = "↑";
            }
        }
        private void UpdateCharacters()
        {
            player.Location = game.PlayerLocation;
            playerHitPoints.Text = game.PlayerHitPoints.ToString();
            
            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    bat.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghost)
                {
                    ghost.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghoul)
                {
                    ghoul.Location = enemy.Location;
                    ghoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }

            if (!showBat)
            {
                bat.Visible = false;
                batHitPoints.Text = "";
            }
            else
                bat.Visible = true;
            if (!showGhost)
            {
                ghost.Visible = false;
                ghostHitPoints.Text = "";
            }
            else
                ghost.Visible = true;
            if (!showGhoul)
            {
                ghoul.Visible = false;
                ghoulHitPoints.Text = "";
            }
            else
                ghoul.Visible = true;

            
            sword.Visible = false;
            bow.Visible = false;
            redPotion.Visible = false;
            bluePotion.Visible = false;
            maczuga.Visible = false;
            Control weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = sword; break;
                case "Bow":
                    weaponControl = bow; break;
                case "Red Potion":
                    weaponControl = redPotion; break;
                case "Blue Potion":
                    weaponControl = bluePotion; break;
                case "Maczuga":
                    weaponControl = maczuga; break;
                default:
                    break;
            }
            weaponControl.Visible = true;
           
            swordClick.Visible = false;
            bowClick.Visible = false;
            maczugaClick.Visible = false;
            redPotionClick.Visible = false;
            bluePotionClick.Visible = false;
            if (game.CheckPlayerInventory("Sword"))
                swordClick.Visible = true;
            if (game.CheckPlayerInventory("Bow"))
                bowClick.Visible = true;
            if (game.CheckPlayerInventory("Maczuga"))
                maczugaClick.Visible = true;
            if (game.CheckPlayerInventory("Red Potion"))
                redPotionClick.Visible = true;
            if (game.CheckPlayerInventory("Blue Potion"))
                bluePotionClick.Visible = true;
           
            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
                weaponControl.Visible = false;
            else
                weaponControl.Visible = true;
            
            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("Umarłeś!");
                Application.Exit();
            }

            if (enemiesShown < 1)
            {
                MessageBox.Show("Pokonałeś wszystkich na tym poziomie!");
                game.NewLevel(random);
                UpdateCharacters();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 480, 195));
            game.NewLevel(random);
            UpdateCharacters();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.W:
                    {
                        game.Move(Direction.Up, random);
                        UpdateCharacters();
                        break;
                    }
                case Keys.A:
                    {
                        game.Move(Direction.Left, random);
                        UpdateCharacters();
                        break;
                    }
                case Keys.S:
                    {
                        game.Move(Direction.Down, random);
                        UpdateCharacters();
                        break;
                    }
                case Keys.D:
                    {
                        game.Move(Direction.Right, random);
                        UpdateCharacters();
                        break;
                    }
            }
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.W:
                    {
                        game.Attack(Direction.Up, random);
                        UpdateCharacters();
                        break;
                    }
                case Keys.A:
                    {
                        game.Attack(Direction.Left, random);
                        UpdateCharacters();
                        break;
                    }
                case Keys.S:
                    {
                        game.Attack(Direction.Down, random);
                        UpdateCharacters();
                        break;
                    }
                case Keys.D:
                    {
                        game.Attack(Direction.Right, random);
                        UpdateCharacters();
                        break;
                    }
            }
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.W:
                    {
                        game.Move(Direction.Up, random);
                        UpdateCharacters();
                        break;
                    }
                case Keys.A:
                    {
                        game.Move(Direction.Left, random);
                        UpdateCharacters();
                        break;
                    }
                case Keys.S:
                    {
                        game.Move(Direction.Down, random);
                        UpdateCharacters();
                        break;
                    }
                case Keys.D:
                    {
                        game.Move(Direction.Right, random);
                        UpdateCharacters();
                        break;
                    }
                case Keys.I:
                    {
                        game.Attack(Direction.Up, random);
                        UpdateCharacters();
                        break;
                    }
                case Keys.J:
                    {
                        game.Attack(Direction.Left, random);
                        UpdateCharacters();
                        break;
                    }
                case Keys.K:
                    {
                        game.Attack(Direction.Down, random);
                        UpdateCharacters();
                        break;
                    }
                case Keys.L:
                    {
                        game.Attack(Direction.Right, random);
                        UpdateCharacters();
                        break;
                    }
                
            }
        }
    }
}
