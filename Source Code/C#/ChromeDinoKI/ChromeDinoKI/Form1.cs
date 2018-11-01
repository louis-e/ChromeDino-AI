using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChromeDinoKI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int count = 0;
        private int count2 = 1;
        private int bestscore;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            RichTextBox1.Text = "starting...";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Timer1.Stop();
        }

        private int waitForNext = 20;
        public void AskForpixel(int x, int y)
        {
            Bitmap b = new Bitmap(1, 1);
            using (Graphics g = Graphics.FromImage(b))
            {

                g.CopyFromScreen(x, y, 0, 0, new Size(1, 1));
            }
            Color cl = b.GetPixel(0, 0);
            string cls = cl.ToString();
            

            if (cls == "Color [A=255, R=83, G=83, B=83]")
            {
                Keyboard.ReleaseKey(Keys.Down);
                waitForNext = 20;
                RichTextBox1.AppendText("\r\n" + "recognized obstacle: " + "X:" + x.ToString() + " " + "Y:" + y.ToString());
                SendKeys.Send(" ");
                count = count + 1;
                Label1.Text = count.ToString();
            }
            else if (waitForNext > 0)
                waitForNext = waitForNext - 1;
            else
            {
                Keyboard.HoldKey(Keys.Down);
                waitForNext = 20;
            }
        }

        public void AskForGameEnd()
        {
            Bitmap b = new Bitmap(1, 1);
            using (Graphics g = Graphics.FromImage(b))
            {
                g.CopyFromScreen(701, 360, 0, 0, new Size(1, 1));
            }
            Color cl = b.GetPixel(0, 0);
            string cls = cl.ToString();


            if (cls == "Color [A=255, R=83, G=83, B=83]")
            {
                if (count > bestscore)
                {
                    bestscore = count;
                    Label5.Text = bestscore.ToString() + "A";
                }

                count = 0;
                Label1.Text = "0";

                count2 = count2 + 1;
                Label7.Text = count2.ToString();

                RichTextBox1.Text = "";
                RichTextBox1.Text = "recognized game end" + "\r\n" + "restarting...";
                SendKeys.Send(" ");
            }
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            AskForpixel(512, 387);
            AskForpixel(512, 387);
            AskForpixel(513, 387);
            AskForpixel(513, 387);
            AskForpixel(514, 387);
            AskForpixel(514, 387);
            AskForpixel(515, 387);
            AskForpixel(515, 387);
            AskForpixel(516, 387);
            AskForpixel(516, 387);
            AskForpixel(517, 387);
            AskForpixel(517, 387);
            AskForpixel(518, 387);
            AskForpixel(518, 387);
            AskForpixel(519, 387);
            AskForpixel(519, 387);
            AskForpixel(520, 387);
            AskForpixel(520, 387);
            AskForpixel(521, 387);
            AskForpixel(521, 387);
            AskForpixel(522, 387);
            AskForpixel(522, 387);
            AskForpixel(523, 387);
            AskForpixel(523, 387);
        }

        private void Timer2_Tick_1(object sender, EventArgs e)
        {
            AskForGameEnd();
            RichTextBox1.Text = "";
        }

        bool btn = true;
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (btn == false)
            {
                btn = true;
                button1.Text = "START";
                Timer1.Stop();
                Timer2.Stop();
            }
            else
            {
                btn = false;
                button1.Text = "STOP";
                Timer1.Start();
                Timer2.Start();
            }
        }
    }
}