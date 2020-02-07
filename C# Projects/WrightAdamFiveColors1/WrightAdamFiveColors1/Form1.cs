using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WrightAdamFiveColors1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkViolet;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.BackColor = DefaultBackColor;

        }
    }
}
