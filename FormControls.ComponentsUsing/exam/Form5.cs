using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace exam
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            string terskelime = "";
            foreach (char harf in metin)
            {
                terskelime = harf.ToString() + terskelime;
            }
            label2.Text = terskelime;
        }
    }
}
