﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KłopotyWPracy
{
    public partial class Form1 : Form
    {
        private Excuse currentExcuse = new Excuse();
        private string selectedFolder = "";
        private bool fromChanged = false;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            currentExcuse.LastUsed = lastUsed.Value;
        }
        public void UpdateForm(bool changed)
        {
            if (!changed)
            {
                this.descryption.Text = currentExcuse.Descryption;
                this.results.Text = currentExcuse.Results;
                this.lastUsed.Value = currentExcuse.LastUsed;
                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                    fileData.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                this.Text = "Program do zarządzania wymówkami";
            }
            else
            {
                this.Text = "Program do zarządzania wymówkami";
                this.fromChanged = changed;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = selectedFolder;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                selectedFolder = folderBrowserDialog1.SelectedPath;
                save.Enabled = true;
                open.Enabled = true;
                randomExcuse.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(descryption.Text) || String.IsNullOrEmpty(results.Text)){
                MessageBox.Show("Określ wymówkę i rezultat", "Nie możesz zapisać pliku", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            saveFileDialog1.InitialDirectory = selectedFolder;
            saveFileDialog1.Filter = "Pliki tekstowe (*.excuse)|*.excuse|Wszystkie pliki (*.*)|*.*";
            saveFileDialog1.FileName = descryption.Text + ".excuse";
            DialogResult result = saveFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                currentExcuse.Save(saveFileDialog1.FileName);
                UpdateForm(false);
                MessageBox.Show("Wymówka zapisana");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                openFileDialog1.InitialDirectory = selectedFolder;
                openFileDialog1.Filter = "Pliki tekstowe (*.excuse)|*.excuse|Wszystkie pliki (*.*)|*.*";
                openFileDialog1.FileName = descryption.Text + ".excuse";
                DialogResult result = openFileDialog1.ShowDialog();
                if(result == DialogResult.OK)
                {
                    currentExcuse = new Excuse(openFileDialog1.FileName);
                        UpdateForm(false);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                currentExcuse = new Excuse(random, selectedFolder);
                UpdateForm(false);
            }
        }
        private bool CheckChanged()
        {
            if (fromChanged)
            {
                DialogResult result = MessageBox.Show("Bieżąca wymówka nie została zapisana. Czy kontynuować?", "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return false;
            }
            return true;
        }

        private void descryption_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Descryption = descryption.Text;
            UpdateForm(true);
        }

        private void results_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = results.Text;
            UpdateForm(true);
        }

        private void lastUsed_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = lastUsed.Value;
            UpdateForm(true);
        }
    }
}
