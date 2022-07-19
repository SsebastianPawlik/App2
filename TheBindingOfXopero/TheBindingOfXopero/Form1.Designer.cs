namespace TheBindingOfXopero
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.player = new System.Windows.Forms.PictureBox();
            this.bat = new System.Windows.Forms.PictureBox();
            this.ghost = new System.Windows.Forms.PictureBox();
            this.ghoul = new System.Windows.Forms.PictureBox();
            this.redPotion = new System.Windows.Forms.PictureBox();
            this.bluePotion = new System.Windows.Forms.PictureBox();
            this.sword = new System.Windows.Forms.PictureBox();
            this.bow = new System.Windows.Forms.PictureBox();
            this.maczuga = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Atak = new System.Windows.Forms.Label();
            this.atackUp = new System.Windows.Forms.Button();
            this.atackDown = new System.Windows.Forms.Button();
            this.atackRight = new System.Windows.Forms.Button();
            this.atackLeft = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Ruch = new System.Windows.Forms.Label();
            this.moveLeft = new System.Windows.Forms.Button();
            this.moveUp = new System.Windows.Forms.Button();
            this.moveDown = new System.Windows.Forms.Button();
            this.moveRight = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ghoulHitPoints = new System.Windows.Forms.Label();
            this.ghostHitPoints = new System.Windows.Forms.Label();
            this.batHitPoints = new System.Windows.Forms.Label();
            this.playerHitPoints = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maczugaClick = new System.Windows.Forms.PictureBox();
            this.bowClick = new System.Windows.Forms.PictureBox();
            this.bluePotionClick = new System.Windows.Forms.PictureBox();
            this.redPotionClick = new System.Windows.Forms.PictureBox();
            this.swordClick = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maczuga)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maczugaClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordClick)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(74, 57);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(35, 35);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // bat
            // 
            this.bat.BackColor = System.Drawing.Color.Transparent;
            this.bat.Image = ((System.Drawing.Image)(resources.GetObject("bat.Image")));
            this.bat.Location = new System.Drawing.Point(115, 57);
            this.bat.Name = "bat";
            this.bat.Size = new System.Drawing.Size(35, 35);
            this.bat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bat.TabIndex = 1;
            this.bat.TabStop = false;
            this.bat.Visible = false;
            // 
            // ghost
            // 
            this.ghost.BackColor = System.Drawing.Color.Transparent;
            this.ghost.Image = ((System.Drawing.Image)(resources.GetObject("ghost.Image")));
            this.ghost.Location = new System.Drawing.Point(156, 57);
            this.ghost.Name = "ghost";
            this.ghost.Size = new System.Drawing.Size(35, 35);
            this.ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghost.TabIndex = 2;
            this.ghost.TabStop = false;
            this.ghost.Visible = false;
            // 
            // ghoul
            // 
            this.ghoul.BackColor = System.Drawing.Color.Transparent;
            this.ghoul.Image = ((System.Drawing.Image)(resources.GetObject("ghoul.Image")));
            this.ghoul.Location = new System.Drawing.Point(197, 57);
            this.ghoul.Name = "ghoul";
            this.ghoul.Size = new System.Drawing.Size(35, 35);
            this.ghoul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghoul.TabIndex = 3;
            this.ghoul.TabStop = false;
            this.ghoul.Visible = false;
            // 
            // redPotion
            // 
            this.redPotion.BackColor = System.Drawing.Color.Transparent;
            this.redPotion.Image = ((System.Drawing.Image)(resources.GetObject("redPotion.Image")));
            this.redPotion.Location = new System.Drawing.Point(238, 57);
            this.redPotion.Name = "redPotion";
            this.redPotion.Size = new System.Drawing.Size(35, 35);
            this.redPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redPotion.TabIndex = 4;
            this.redPotion.TabStop = false;
            this.redPotion.Visible = false;
            this.redPotion.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // bluePotion
            // 
            this.bluePotion.BackColor = System.Drawing.Color.Transparent;
            this.bluePotion.Image = ((System.Drawing.Image)(resources.GetObject("bluePotion.Image")));
            this.bluePotion.Location = new System.Drawing.Point(279, 57);
            this.bluePotion.Name = "bluePotion";
            this.bluePotion.Size = new System.Drawing.Size(35, 35);
            this.bluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bluePotion.TabIndex = 5;
            this.bluePotion.TabStop = false;
            this.bluePotion.Visible = false;
            // 
            // sword
            // 
            this.sword.BackColor = System.Drawing.Color.Transparent;
            this.sword.Image = ((System.Drawing.Image)(resources.GetObject("sword.Image")));
            this.sword.Location = new System.Drawing.Point(320, 57);
            this.sword.Name = "sword";
            this.sword.Size = new System.Drawing.Size(35, 35);
            this.sword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sword.TabIndex = 6;
            this.sword.TabStop = false;
            this.sword.Visible = false;
            // 
            // bow
            // 
            this.bow.BackColor = System.Drawing.Color.Transparent;
            this.bow.Image = ((System.Drawing.Image)(resources.GetObject("bow.Image")));
            this.bow.Location = new System.Drawing.Point(361, 57);
            this.bow.Name = "bow";
            this.bow.Size = new System.Drawing.Size(35, 35);
            this.bow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bow.TabIndex = 7;
            this.bow.TabStop = false;
            this.bow.Visible = false;
            // 
            // maczuga
            // 
            this.maczuga.BackColor = System.Drawing.Color.Transparent;
            this.maczuga.Image = ((System.Drawing.Image)(resources.GetObject("maczuga.Image")));
            this.maczuga.Location = new System.Drawing.Point(402, 57);
            this.maczuga.Name = "maczuga";
            this.maczuga.Size = new System.Drawing.Size(35, 35);
            this.maczuga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maczuga.TabIndex = 8;
            this.maczuga.TabStop = false;
            this.maczuga.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Atak, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.atackUp, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.atackDown, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.atackRight, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.atackLeft, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(418, 311);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(118, 76);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // Atak
            // 
            this.Atak.AutoSize = true;
            this.Atak.Location = new System.Drawing.Point(41, 0);
            this.Atak.Name = "Atak";
            this.Atak.Size = new System.Drawing.Size(29, 13);
            this.Atak.TabIndex = 0;
            this.Atak.Text = "Atak";
            // 
            // atackUp
            // 
            this.atackUp.Location = new System.Drawing.Point(41, 17);
            this.atackUp.Name = "atackUp";
            this.atackUp.Size = new System.Drawing.Size(35, 23);
            this.atackUp.TabIndex = 1;
            this.atackUp.Text = "↑";
            this.atackUp.UseVisualStyleBackColor = true;
            this.atackUp.Click += new System.EventHandler(this.atackUp_Click);
            // 
            // atackDown
            // 
            this.atackDown.Location = new System.Drawing.Point(41, 48);
            this.atackDown.Name = "atackDown";
            this.atackDown.Size = new System.Drawing.Size(35, 23);
            this.atackDown.TabIndex = 2;
            this.atackDown.Text = "↓";
            this.atackDown.UseVisualStyleBackColor = true;
            this.atackDown.Click += new System.EventHandler(this.atackDown_Click);
            // 
            // atackRight
            // 
            this.atackRight.Location = new System.Drawing.Point(82, 17);
            this.atackRight.Name = "atackRight";
            this.atackRight.Size = new System.Drawing.Size(33, 23);
            this.atackRight.TabIndex = 3;
            this.atackRight.Text = "→";
            this.atackRight.UseVisualStyleBackColor = true;
            this.atackRight.Click += new System.EventHandler(this.atackRight_Click);
            // 
            // atackLeft
            // 
            this.atackLeft.Location = new System.Drawing.Point(3, 17);
            this.atackLeft.Name = "atackLeft";
            this.atackLeft.Size = new System.Drawing.Size(32, 23);
            this.atackLeft.TabIndex = 4;
            this.atackLeft.Text = "←";
            this.atackLeft.UseVisualStyleBackColor = true;
            this.atackLeft.Click += new System.EventHandler(this.atackLeft_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.Ruch, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.moveLeft, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.moveUp, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.moveDown, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.moveRight, 2, 2);
            this.tableLayoutPanel2.Enabled = false;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(298, 308);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(117, 76);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // Ruch
            // 
            this.Ruch.AutoSize = true;
            this.Ruch.Location = new System.Drawing.Point(41, 0);
            this.Ruch.Name = "Ruch";
            this.Ruch.Size = new System.Drawing.Size(33, 13);
            this.Ruch.TabIndex = 0;
            this.Ruch.Text = "Ruch";
            // 
            // moveLeft
            // 
            this.moveLeft.Location = new System.Drawing.Point(3, 20);
            this.moveLeft.Name = "moveLeft";
            this.moveLeft.Size = new System.Drawing.Size(32, 24);
            this.moveLeft.TabIndex = 1;
            this.moveLeft.Text = "←";
            this.moveLeft.UseVisualStyleBackColor = true;
            this.moveLeft.Click += new System.EventHandler(this.moveLeft_Click);
            // 
            // moveUp
            // 
            this.moveUp.Location = new System.Drawing.Point(41, 20);
            this.moveUp.Name = "moveUp";
            this.moveUp.Size = new System.Drawing.Size(35, 23);
            this.moveUp.TabIndex = 2;
            this.moveUp.Text = "↑";
            this.moveUp.UseVisualStyleBackColor = true;
            this.moveUp.Click += new System.EventHandler(this.moveUp_Click);
            // 
            // moveDown
            // 
            this.moveDown.Location = new System.Drawing.Point(41, 50);
            this.moveDown.Name = "moveDown";
            this.moveDown.Size = new System.Drawing.Size(35, 23);
            this.moveDown.TabIndex = 3;
            this.moveDown.Text = "↓";
            this.moveDown.UseVisualStyleBackColor = true;
            this.moveDown.Click += new System.EventHandler(this.moveDown_Click);
            // 
            // moveRight
            // 
            this.moveRight.Location = new System.Drawing.Point(82, 20);
            this.moveRight.Name = "moveRight";
            this.moveRight.Size = new System.Drawing.Size(32, 23);
            this.moveRight.TabIndex = 4;
            this.moveRight.Text = "→";
            this.moveRight.UseVisualStyleBackColor = true;
            this.moveRight.Click += new System.EventHandler(this.moveRight_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel3.Controls.Add(this.ghoulHitPoints, 1, 8);
            this.tableLayoutPanel3.Controls.Add(this.ghostHitPoints, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.batHitPoints, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.playerHitPoints, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 6);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(402, 225);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 9;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(148, 77);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // ghoulHitPoints
            // 
            this.ghoulHitPoints.AutoSize = true;
            this.ghoulHitPoints.Location = new System.Drawing.Point(63, 58);
            this.ghoulHitPoints.Name = "ghoulHitPoints";
            this.ghoulHitPoints.Size = new System.Drawing.Size(75, 13);
            this.ghoulHitPoints.TabIndex = 12;
            this.ghoulHitPoints.Text = "ghoulHitPoints";
            // 
            // ghostHitPoints
            // 
            this.ghostHitPoints.AutoSize = true;
            this.ghostHitPoints.Location = new System.Drawing.Point(63, 38);
            this.ghostHitPoints.Name = "ghostHitPoints";
            this.ghostHitPoints.Size = new System.Drawing.Size(75, 13);
            this.ghostHitPoints.TabIndex = 12;
            this.ghostHitPoints.Text = "ghostHitPoints";
            // 
            // batHitPoints
            // 
            this.batHitPoints.AutoSize = true;
            this.batHitPoints.Location = new System.Drawing.Point(63, 17);
            this.batHitPoints.Name = "batHitPoints";
            this.batHitPoints.Size = new System.Drawing.Size(64, 13);
            this.batHitPoints.TabIndex = 12;
            this.batHitPoints.Text = "batHitPoints";
            // 
            // playerHitPoints
            // 
            this.playerHitPoints.AutoSize = true;
            this.playerHitPoints.Location = new System.Drawing.Point(63, 0);
            this.playerHitPoints.Name = "playerHitPoints";
            this.playerHitPoints.Size = new System.Drawing.Size(77, 13);
            this.playerHitPoints.TabIndex = 4;
            this.playerHitPoints.Text = "playerHitPoints";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Upiór";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gracz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nietoperz";
            // 
            // maczugaClick
            // 
            this.maczugaClick.BackColor = System.Drawing.Color.Transparent;
            this.maczugaClick.Image = ((System.Drawing.Image)(resources.GetObject("maczugaClick.Image")));
            this.maczugaClick.Location = new System.Drawing.Point(74, 321);
            this.maczugaClick.Name = "maczugaClick";
            this.maczugaClick.Size = new System.Drawing.Size(50, 50);
            this.maczugaClick.TabIndex = 12;
            this.maczugaClick.TabStop = false;
            this.maczugaClick.Click += new System.EventHandler(this.maczugaClick_Click);
            // 
            // bowClick
            // 
            this.bowClick.BackColor = System.Drawing.Color.Transparent;
            this.bowClick.Image = ((System.Drawing.Image)(resources.GetObject("bowClick.Image")));
            this.bowClick.Location = new System.Drawing.Point(130, 321);
            this.bowClick.Name = "bowClick";
            this.bowClick.Size = new System.Drawing.Size(50, 50);
            this.bowClick.TabIndex = 13;
            this.bowClick.TabStop = false;
            this.bowClick.Click += new System.EventHandler(this.bowClick_Click);
            // 
            // bluePotionClick
            // 
            this.bluePotionClick.BackColor = System.Drawing.Color.Transparent;
            this.bluePotionClick.Image = ((System.Drawing.Image)(resources.GetObject("bluePotionClick.Image")));
            this.bluePotionClick.Location = new System.Drawing.Point(186, 321);
            this.bluePotionClick.Name = "bluePotionClick";
            this.bluePotionClick.Size = new System.Drawing.Size(50, 50);
            this.bluePotionClick.TabIndex = 14;
            this.bluePotionClick.TabStop = false;
            this.bluePotionClick.Click += new System.EventHandler(this.bluePotionClick_Click);
            // 
            // redPotionClick
            // 
            this.redPotionClick.BackColor = System.Drawing.Color.Transparent;
            this.redPotionClick.Image = ((System.Drawing.Image)(resources.GetObject("redPotionClick.Image")));
            this.redPotionClick.Location = new System.Drawing.Point(242, 321);
            this.redPotionClick.Name = "redPotionClick";
            this.redPotionClick.Size = new System.Drawing.Size(50, 50);
            this.redPotionClick.TabIndex = 15;
            this.redPotionClick.TabStop = false;
            this.redPotionClick.Click += new System.EventHandler(this.redPotionClick_Click);
            // 
            // swordClick
            // 
            this.swordClick.BackColor = System.Drawing.Color.Transparent;
            this.swordClick.Image = ((System.Drawing.Image)(resources.GetObject("swordClick.Image")));
            this.swordClick.Location = new System.Drawing.Point(18, 321);
            this.swordClick.Name = "swordClick";
            this.swordClick.Size = new System.Drawing.Size(50, 50);
            this.swordClick.TabIndex = 16;
            this.swordClick.TabStop = false;
            this.swordClick.Click += new System.EventHandler(this.swordClick_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(217, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Poruszanie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(301, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Atak";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button2_KeyDown);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(484, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Graj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button3_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(599, 399);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.swordClick);
            this.Controls.Add(this.redPotionClick);
            this.Controls.Add(this.bluePotionClick);
            this.Controls.Add(this.bowClick);
            this.Controls.Add(this.maczugaClick);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.maczuga);
            this.Controls.Add(this.bow);
            this.Controls.Add(this.sword);
            this.Controls.Add(this.bluePotion);
            this.Controls.Add(this.redPotion);
            this.Controls.Add(this.ghoul);
            this.Controls.Add(this.ghost);
            this.Controls.Add(this.bat);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maczuga)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maczugaClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordClick)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox bat;
        private System.Windows.Forms.PictureBox ghost;
        private System.Windows.Forms.PictureBox ghoul;
        private System.Windows.Forms.PictureBox redPotion;
        private System.Windows.Forms.PictureBox bluePotion;
        private System.Windows.Forms.PictureBox sword;
        private System.Windows.Forms.PictureBox bow;
        private System.Windows.Forms.PictureBox maczuga;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label Atak;
        private System.Windows.Forms.Button atackUp;
        private System.Windows.Forms.Button atackDown;
        private System.Windows.Forms.Button atackRight;
        private System.Windows.Forms.Button atackLeft;
        private System.Windows.Forms.Label Ruch;
        private System.Windows.Forms.Button moveLeft;
        private System.Windows.Forms.Button moveUp;
        private System.Windows.Forms.Button moveDown;
        private System.Windows.Forms.Button moveRight;
        private System.Windows.Forms.Label ghoulHitPoints;
        private System.Windows.Forms.Label ghostHitPoints;
        private System.Windows.Forms.Label batHitPoints;
        private System.Windows.Forms.Label playerHitPoints;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox maczugaClick;
        private System.Windows.Forms.PictureBox bowClick;
        private System.Windows.Forms.PictureBox bluePotionClick;
        private System.Windows.Forms.PictureBox redPotionClick;
        private System.Windows.Forms.PictureBox swordClick;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

