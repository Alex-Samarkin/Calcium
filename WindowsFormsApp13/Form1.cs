using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            X = 0;
            Y = 0;
            Z = 0;
        }

        private double x = 0;
        private List<double> log_x = new List<double>();
        public double X
        {
            get { 
                var tmp = x;
                bool success = double.TryParse(textBox1.Text, out tmp);
                x = success ? tmp : x;
                textBox1.Text = x.ToString();
                return x;
            }
            set { x = value; textBox1.Text = x.ToString(); 
                log_x.Add(x); }
        }
        
        private double y = 0;
        public double Y
        {
            get
            {
                var tmp = y;
                bool success = double.TryParse(textBox2.Text, out tmp);
                y = success ? tmp : y;
                textBox2.Text = y.ToString();
                return y;
            }
            set { y = value; textBox2.Text = y.ToString(); }
        }
        private double z = 0;

        public double Z
        {
            get
            {
                var tmp = z;
                bool success = double.TryParse(textBox3.Text, out tmp);
                z = success ? tmp : z;
                textBox3.Text = z.ToString();
                return z;
            }
            set { z = value; textBox3.Text = z.ToString(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            X = X+Y;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            X = X - Y;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            X = X * Y;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            X = X / Y;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            X = X * X;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            X = X * X * X;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            X = Math.Pow(X, Y);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            X = Math.Pow(X, 1/Y);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            X = Math.Sqrt(X);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            X = Math.Pow(X, 1 / 3.0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            X = Math.PI;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            X = Math.PI * 2;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            X = Math.PI / 2;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            X = Math.PI / 3;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            X = Math.PI / 4;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            X = Math.PI / 6;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            X = 1 / Math.PI;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            X = Math.PI*Math.PI;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            X = Math.Exp(X);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            X = Math.Exp(1/X);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            X =Math.Exp(-X);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            X =Math.Log(X);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            X = Math.Log10(X);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            X = Math.Log(X, 2);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            X = Math.Log(X, Y);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            X = -X;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            X = 1 / X;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            X = X * 10;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            X = X / 10;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            X = X + 1;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            X = X - 1;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            X = (int)X /(int) Y;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            X = X % Y;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            X = X / Y * 100;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            X = Math.Ceiling(X);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            X = Math.Truncate(X);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            X = Math.Round(X,0);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            X = Math.Round(X, 1);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            X = Math.Round(X, 2);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            X = Math.Round(X, 3);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Z = Y;
            Y = X;

        }

        private void button42_Click(object sender, EventArgs e)
        {
            var tmp = X;
            X = Y;
            Y = tmp;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            var tmp =X;
            X = Z;
            Z = tmp;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Z = X;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            var tmp = Z;
            Z = Y;
            Y = X;
            X = tmp;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Y = X;
        }

        private Random random = new Random();

        private void button47_Click(object sender, EventArgs e)
        {
            X = random.NextDouble();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            X = random.NextDouble() * 100;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            X = random.NextDouble() * Y;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            X = log_x[log_x.Count - 2];
        }

        private void button50_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void button50_MouseDown(object sender, MouseEventArgs e)
        {
            var i = log_x.Count - 2 - e.Delta;
            if (i < 0) i = 0;
            if (i > log_x.Count - 2) i = log_x.Count - 2;
            X = log_x[i];
        }

        private void button51_Click(object sender, EventArgs e)
        {
            X = Math.Sin(X);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            X = Math.Cos(X);
        }
    }
}
