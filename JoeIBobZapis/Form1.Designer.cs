namespace form4
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
            this.joeCashLable = new System.Windows.Forms.Label();
            this.bobCashLable = new System.Windows.Forms.Label();
            this.bankCashLable = new System.Windows.Forms.Label();
            this.reciveCash = new System.Windows.Forms.Button();
            this.GiveCash = new System.Windows.Forms.Button();
            this.joeGive = new System.Windows.Forms.Button();
            this.bobGive = new System.Windows.Forms.Button();
            this.saveJoe = new System.Windows.Forms.Button();
            this.loadJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joeCashLable
            // 
            this.joeCashLable.AutoSize = true;
            this.joeCashLable.Location = new System.Drawing.Point(12, 9);
            this.joeCashLable.Name = "joeCashLable";
            this.joeCashLable.Size = new System.Drawing.Size(68, 13);
            this.joeCashLable.TabIndex = 0;
            this.joeCashLable.Text = "Joe ma 50 zł";
            // 
            // bobCashLable
            // 
            this.bobCashLable.AutoSize = true;
            this.bobCashLable.Location = new System.Drawing.Point(12, 43);
            this.bobCashLable.Name = "bobCashLable";
            this.bobCashLable.Size = new System.Drawing.Size(76, 13);
            this.bobCashLable.TabIndex = 1;
            this.bobCashLable.Text = "Bob ma 100 zł";
            // 
            // bankCashLable
            // 
            this.bankCashLable.AutoSize = true;
            this.bankCashLable.Location = new System.Drawing.Point(12, 76);
            this.bankCashLable.Name = "bankCashLable";
            this.bankCashLable.Size = new System.Drawing.Size(82, 13);
            this.bankCashLable.TabIndex = 2;
            this.bankCashLable.Text = "Bank ma 100 zł";
            // 
            // reciveCash
            // 
            this.reciveCash.Location = new System.Drawing.Point(12, 107);
            this.reciveCash.Name = "reciveCash";
            this.reciveCash.Size = new System.Drawing.Size(97, 23);
            this.reciveCash.TabIndex = 3;
            this.reciveCash.Text = "Daj 10 zł Joemu";
            this.reciveCash.UseVisualStyleBackColor = true;
            this.reciveCash.Click += new System.EventHandler(this.reciveCash_Click);
            // 
            // GiveCash
            // 
            this.GiveCash.Location = new System.Drawing.Point(115, 107);
            this.GiveCash.Name = "GiveCash";
            this.GiveCash.Size = new System.Drawing.Size(102, 23);
            this.GiveCash.TabIndex = 4;
            this.GiveCash.Text = "Weź 5 zł od Boba";
            this.GiveCash.UseVisualStyleBackColor = true;
            this.GiveCash.Click += new System.EventHandler(this.GiveCash_Click);
            // 
            // joeGive
            // 
            this.joeGive.Location = new System.Drawing.Point(12, 136);
            this.joeGive.Name = "joeGive";
            this.joeGive.Size = new System.Drawing.Size(97, 23);
            this.joeGive.TabIndex = 5;
            this.joeGive.Text = "Joe daje bobowi";
            this.joeGive.UseVisualStyleBackColor = true;
            this.joeGive.Click += new System.EventHandler(this.joeGive_Click);
            // 
            // bobGive
            // 
            this.bobGive.Location = new System.Drawing.Point(115, 136);
            this.bobGive.Name = "bobGive";
            this.bobGive.Size = new System.Drawing.Size(102, 23);
            this.bobGive.TabIndex = 6;
            this.bobGive.Text = "Bob daje joemu";
            this.bobGive.UseVisualStyleBackColor = true;
            this.bobGive.Click += new System.EventHandler(this.bobGive_Click);
            // 
            // saveJoe
            // 
            this.saveJoe.Location = new System.Drawing.Point(12, 165);
            this.saveJoe.Name = "saveJoe";
            this.saveJoe.Size = new System.Drawing.Size(97, 23);
            this.saveJoe.TabIndex = 7;
            this.saveJoe.Text = "Zapisz joego";
            this.saveJoe.UseVisualStyleBackColor = true;
            this.saveJoe.Click += new System.EventHandler(this.saveJoe_Click);
            // 
            // loadJoe
            // 
            this.loadJoe.Location = new System.Drawing.Point(115, 165);
            this.loadJoe.Name = "loadJoe";
            this.loadJoe.Size = new System.Drawing.Size(102, 23);
            this.loadJoe.TabIndex = 8;
            this.loadJoe.Text = "Wczytaj Joego";
            this.loadJoe.UseVisualStyleBackColor = true;
            this.loadJoe.Click += new System.EventHandler(this.loadJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 196);
            this.Controls.Add(this.loadJoe);
            this.Controls.Add(this.saveJoe);
            this.Controls.Add(this.bobGive);
            this.Controls.Add(this.joeGive);
            this.Controls.Add(this.GiveCash);
            this.Controls.Add(this.reciveCash);
            this.Controls.Add(this.bankCashLable);
            this.Controls.Add(this.bobCashLable);
            this.Controls.Add(this.joeCashLable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label joeCashLable;
        private System.Windows.Forms.Label bobCashLable;
        private System.Windows.Forms.Label bankCashLable;
        private System.Windows.Forms.Button reciveCash;
        private System.Windows.Forms.Button GiveCash;
        private System.Windows.Forms.Button joeGive;
        private System.Windows.Forms.Button bobGive;
        private System.Windows.Forms.Button saveJoe;
        private System.Windows.Forms.Button loadJoe;
    }
}

