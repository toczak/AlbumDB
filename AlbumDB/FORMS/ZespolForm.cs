﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumDB.FORMS
{
    public partial class ZespolForm : Form
    {
        public ZespolForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || numericUpDown1.Value == 0)
            {
                MessageBox.Show("Wprowadż poprawne wartości do wszystkich pól", "Ostrzeżenie", MessageBoxButtons.OK);
                return;
            }

            if (InsertIntoDatabase.Insert("zespol", textBox1.Text, textBox2.Text, numericUpDown1.Value))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void ZespolForm_Load(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = DateTime.Now.Year;
            numericUpDown1.Value = DateTime.Now.Year;
        }
    }
}
