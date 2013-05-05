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
    public partial class Form2 : Form
    {
        int[] dizi = new int[10];
        int i = 0;
        int min, max, top, temp1, temp2;
        int ort;
        int count = 0;
        int en_s;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            min = dizi[0];
            max = dizi[0];
            ort = 0;
            top = 0;
            for (i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] != 0)
                {
                    if (min > dizi[i])
                        min = dizi[i];
                    if (max < dizi[i])
                        max = dizi[i];
                    count += 1;
                }
                top += dizi[i];
            }

            ort = top / count;
            label6.Text = "Ortalama Sayı " + ort;
            label7.Text = "Toplam Sayı " + top;
            label4.Text = "Minimimum Sayı" + min;
            label5.Text = "Maximum Sayı" + max;
            en_s = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dizi[i] = int.Parse(textBox1.Text);
            label3.Text += "\n" + (i + 1) + ".sayi" + dizi[i];
            i++;
        }
    }
}