using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookYa
{
    public partial class Form1 : Form

    {
        System.Timers.Timer t;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this);
            f3.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            timer1.Interval = 1000;
  
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;

                button1.Visible = true;
                button2.Visible = true;
            }
        }
    }
}
