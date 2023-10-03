using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float temperatura= float.Parse(textBox1.Text);
            float f = (temperatura * 9f / 5f) +32 ;
            label2.Text = f.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "0.0";
            label2.Text = "0.0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float tem = float.Parse(textBox1.Text);
            float c = (tem - 32) * 5.0f / 9.0f;
            label1.Text = c.ToString();
        }
    }
}
