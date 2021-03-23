using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QandA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "The 31st President from 1929 to 1933 was Herbert Hoover.";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "Incorrect Answer!";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "Incorrect Answer!";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "Correct! The 31st President from 1929 to 1933 was Herbert Hoover.";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "Incorrect Answer!";
        }
    }
}
