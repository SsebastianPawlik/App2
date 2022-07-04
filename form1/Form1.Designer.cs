namespace form1
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
            this.changeText = new System.Windows.Forms.Button();
            this.lableToChange = new System.Windows.Forms.Label();
            this.enableCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // changeText
            // 
            this.changeText.Location = new System.Drawing.Point(13, 13);
            this.changeText.Name = "changeText";
            this.changeText.Size = new System.Drawing.Size(149, 23);
            this.changeText.TabIndex = 0;
            this.changeText.Text = "Kliknięcie zmieni etykiete";
            this.changeText.UseVisualStyleBackColor = true;
            this.changeText.Click += new System.EventHandler(this.button1_Click);
            // 
            // lableToChange
            // 
            this.lableToChange.Location = new System.Drawing.Point(12, 78);
            this.lableToChange.Name = "lableToChange";
            this.lableToChange.Size = new System.Drawing.Size(544, 23);
            this.lableToChange.TabIndex = 1;
            this.lableToChange.Text = "Naciśnij przyisk, aby mienić tekst";
            this.lableToChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enableCheckbox
            // 
            this.enableCheckbox.AutoSize = true;
            this.enableCheckbox.Checked = true;
            this.enableCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableCheckbox.Location = new System.Drawing.Point(168, 17);
            this.enableCheckbox.Name = "enableCheckbox";
            this.enableCheckbox.Size = new System.Drawing.Size(133, 17);
            this.enableCheckbox.TabIndex = 2;
            this.enableCheckbox.Text = "Włącz zmiane etykiety";
            this.enableCheckbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 234);
            this.Controls.Add(this.enableCheckbox);
            this.Controls.Add(this.lableToChange);
            this.Controls.Add(this.changeText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeText;
        private System.Windows.Forms.Label lableToChange;
        private System.Windows.Forms.CheckBox enableCheckbox;
    }
}

