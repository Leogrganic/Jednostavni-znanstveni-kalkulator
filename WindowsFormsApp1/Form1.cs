using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double v, q;
        double c = 0;
        double l;
        double g = 9.81;
        double t;

        private void button1_Click(object sender, EventArgs e)
        {
            v = Convert.ToDouble(textBox1.Text);
            q = Convert.ToDouble(textBox2.Text);

            if (v != 0)
            {
                c = q/v;
                double rounded1 = Math.Round(c, 4);
                label2.Text = Convert.ToString(rounded1);
            }
            else
            {
                MessageBox.Show("Napon ne može biti jednak nuli");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            l = Convert.ToDouble(textBox3.Text);
            t = 2 * Math.PI * Math.Sqrt(l / g);
            double rounded = Math.Round(t, 4);
            label6.Text = Convert.ToString(rounded);
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
