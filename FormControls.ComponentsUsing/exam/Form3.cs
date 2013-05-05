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
    public partial class Form3 : Form
    {
        

        public Form3()
        {
            InitializeComponent();
            this.CenterToScreen();
        }


        Form4 f4 = new Form4();
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            f4.listBox1.Items.Add(textBox1.Text);
            f4.listBox2.Items.Add(comboBox1.SelectedItem);
            f4.listBox3.Items.Add(comboBox2.SelectedItem);

            if (radioButton1.Checked == true) 
                f4.listBox4.Items.Add(radioButton1.Text);
            if (radioButton2.Checked == true)
                f4.listBox4.Items.Add(radioButton2.Text);

            textBox1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f4.ShowDialog();
        }
    }
}
