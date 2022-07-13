namespace ModelDomu
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
            this.descryption = new System.Windows.Forms.RichTextBox();
            this.goHere = new System.Windows.Forms.Button();
            this.goThroughtDoor = new System.Windows.Forms.Button();
            this.exits = new System.Windows.Forms.ComboBox();
            this.hide = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descryption
            // 
            this.descryption.Location = new System.Drawing.Point(13, 13);
            this.descryption.Name = "descryption";
            this.descryption.Size = new System.Drawing.Size(353, 96);
            this.descryption.TabIndex = 0;
            this.descryption.Text = "";
            // 
            // goHere
            // 
            this.goHere.Location = new System.Drawing.Point(13, 116);
            this.goHere.Name = "goHere";
            this.goHere.Size = new System.Drawing.Size(75, 23);
            this.goHere.TabIndex = 1;
            this.goHere.Text = "Idź tutaj";
            this.goHere.UseVisualStyleBackColor = true;
            this.goHere.Click += new System.EventHandler(this.goHere_Click);
            // 
            // goThroughtDoor
            // 
            this.goThroughtDoor.Location = new System.Drawing.Point(13, 146);
            this.goThroughtDoor.Name = "goThroughtDoor";
            this.goThroughtDoor.Size = new System.Drawing.Size(353, 23);
            this.goThroughtDoor.TabIndex = 2;
            this.goThroughtDoor.Text = "Przejdź przez drzwi ";
            this.goThroughtDoor.UseVisualStyleBackColor = true;
            this.goThroughtDoor.Click += new System.EventHandler(this.goThroughtDoor_Click);
            // 
            // exits
            // 
            this.exits.FormattingEnabled = true;
            this.exits.Location = new System.Drawing.Point(94, 118);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(272, 21);
            this.exits.TabIndex = 3;
            // 
            // hide
            // 
            this.hide.Location = new System.Drawing.Point(13, 176);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(174, 23);
            this.hide.TabIndex = 4;
            this.hide.Text = "Kryj się!";
            this.hide.UseVisualStyleBackColor = true;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(193, 176);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(173, 23);
            this.check.TabIndex = 5;
            this.check.Text = "Sprawdź";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 219);
            this.Controls.Add(this.check);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.exits);
            this.Controls.Add(this.goThroughtDoor);
            this.Controls.Add(this.goHere);
            this.Controls.Add(this.descryption);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox descryption;
        private System.Windows.Forms.Button goHere;
        private System.Windows.Forms.Button goThroughtDoor;
        private System.Windows.Forms.ComboBox exits;
        private System.Windows.Forms.Button hide;
        private System.Windows.Forms.Button check;
    }
}

