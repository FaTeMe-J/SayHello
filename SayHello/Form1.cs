using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayHello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s;
            s = textBox1.Text;
            label2.Text = "Hello " + textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            label2.Text= " ";
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.ForeColor = Color.Yellow;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor= Color.Red;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "all format(*.avi , *.mp3)| *.avi; *.mp3";
            if (op.ShowDialog() == DialogResult.OK)
                axWindowsMediaPlayer1.URL = op.FileName;
        }
    }
}
