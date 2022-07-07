namespace KrystynaObiad_Książka_
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DdekoracjeFfantazyjne = new System.Windows.Forms.CheckBox();
            this.OpcjaZdrowa = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 29);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(56, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Iiość osób";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(9, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Koszt";
            // 
            // DdekoracjeFfantazyjne
            // 
            this.DdekoracjeFfantazyjne.AutoSize = true;
            this.DdekoracjeFfantazyjne.Location = new System.Drawing.Point(12, 55);
            this.DdekoracjeFfantazyjne.Name = "DdekoracjeFfantazyjne";
            this.DdekoracjeFfantazyjne.Size = new System.Drawing.Size(126, 17);
            this.DdekoracjeFfantazyjne.TabIndex = 3;
            this.DdekoracjeFfantazyjne.Text = "Dekoracje fantazyjne";
            this.DdekoracjeFfantazyjne.UseVisualStyleBackColor = true;
            this.DdekoracjeFfantazyjne.CheckedChanged += new System.EventHandler(this.DdekoracjeFfantazyjne_CheckedChanged);
            // 
            // OpcjaZdrowa
            // 
            this.OpcjaZdrowa.AutoSize = true;
            this.OpcjaZdrowa.Location = new System.Drawing.Point(12, 78);
            this.OpcjaZdrowa.Name = "OpcjaZdrowa";
            this.OpcjaZdrowa.Size = new System.Drawing.Size(91, 17);
            this.OpcjaZdrowa.TabIndex = 4;
            this.OpcjaZdrowa.Text = "Opcja zdrowa";
            this.OpcjaZdrowa.UseVisualStyleBackColor = true;
            this.OpcjaZdrowa.CheckedChanged += new System.EventHandler(this.OpcjaZdrowa_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(75, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 164);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OpcjaZdrowa);
            this.Controls.Add(this.DdekoracjeFfantazyjne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox DdekoracjeFfantazyjne;
        private System.Windows.Forms.CheckBox OpcjaZdrowa;
        private System.Windows.Forms.Label label3;
    }
}

