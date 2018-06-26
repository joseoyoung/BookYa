using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookYa
{
    public partial class Form2 : Form
    {
        Form1 f1;

        System.Timers.Timer t;
        public Form2()
        {
            InitializeComponent();
        }
    
        public Form2(Form1 _form)
        {
            InitializeComponent();
            f1 = _form;            
        }

        private void Form2_Load(object sender, EventArgs e)
        {         
            timer1.Start();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            timer1.Interval = 1000;


            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }

            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }

            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }

            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
            }

            else if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
            }

            else if (pictureBox6.Visible == true)
            {
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;
            }

            else if (pictureBox7.Visible == true)
            {
                pictureBox7.Visible = false;
                pictureBox15.Visible = true;

                label1.Visible = true;
                label2.Visible = true;
                timer2.Start();

                pictureBox9.Enabled = true;
            }

            else if (pictureBox15.Visible == true)
            {
                pictureBox15.Visible = false;
                pictureBox16.Visible = true;
            }

            else if (pictureBox16.Visible == true)
            {
                pictureBox16.Visible = false;
                pictureBox17.Visible = true;
            }

            else if (pictureBox17.Visible == true)
            {
                pictureBox17.Visible = false;
                pictureBox18.Visible = true;
            }

            else if (pictureBox18.Visible == true)
            {
                pictureBox18.Visible = false;
                pictureBox19.Visible = true;
            }

            else if (pictureBox19.Visible == true)
            {
                pictureBox19.Visible = false;
                pictureBox20.Visible = true;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox9.Visible == true)
            {
                pictureBox9.Visible = false;
                pictureBox10.Visible = true;
            }      
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (pictureBox10.Visible == true)
            {
                pictureBox10.Visible = false;
                pictureBox11.Visible = true;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (pictureBox11.Visible == true)
            {
                pictureBox11.Visible = false;
                pictureBox12.Visible = true;
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (pictureBox12.Visible == true)
            {
                pictureBox12.Visible = false;
                pictureBox13.Visible = true;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (pictureBox13.Visible == true)
            {
                pictureBox13.Visible = false;
                pictureBox14.Visible = true;

                timer1.Stop();
                timer2.Stop();
                DialogResult dialogResult = MessageBox.Show("                미션 성공! \n   게임을 계속 진행하시겠습니까?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("2단계는 준비 중입니다!");
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }
            }
        }
        SoundPlayer player = new SoundPlayer();
        public static int count = 90;
        private void timer2_Tick(object sender, EventArgs e)
        {           
            count -= 1;
            label2.Text = count.ToString();
  
            if(count == 0)
            {
                timer2.Stop();
                player.SoundLocation = @"C:\Users\Mirim\Desktop\IT쇼\bell.wav";
                player.Play();
                timer3.Enabled = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = true;
                label4.Visible = true;
                timer3.Start();

                pictureBox20.Visible = false;
                pictureBox21.Visible = true;
                pictureBox14.Visible = false;
                pictureBox9.Visible = true;
                pictureBox9.Enabled = false;
            }
        }

        public static int count1 = 30;
        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox9.Enabled = false;
            count1 -= 1;
            label4.Text = count1.ToString();

            if(count1 == 0)
            {
                pictureBox21.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label1.Visible = true;
                label2.Visible = true;
               
                pictureBox2.Visible = false;

                timer4.Enabled = true;
                timer4.Start();
                pictureBox9.Enabled = true;

                count = 90;
                count -= 1;
                timer2.Start();
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {      
            //주석
        }

        
     
    }
}
