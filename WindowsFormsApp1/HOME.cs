using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class gamestart : Form
    {
        int second;
        int useranswer;
        int answer;
        int a;
        int b;

        Random random = new Random();
        int score = 0;
        int highscore;
        int averagepoint;
        int highpoint;
        public gamestart()
        {
            InitializeComponent();
            highscorelabel.Text = Properties.Settings.Default.h_score;


            if (int.TryParse(label1.Text, out a)) ;

            if (int.TryParse(label3.Text, out b)) ;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Useranswer.Text = Useranswer.Text + button8.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Useranswer.Text = Useranswer.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Useranswer.Text = Useranswer.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Useranswer.Text = Useranswer.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Useranswer.Text = Useranswer.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Useranswer.Text = Useranswer.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Useranswer.Text = Useranswer.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Useranswer.Text = Useranswer.Text + button7.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Useranswer.Text = Useranswer.Text + button9.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Useranswer.Text = Useranswer.Text + button11.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Useranswer.Clear();
        }

        private void gamestart_Load(object sender, EventArgs e)
        {
            second = 10;
            countdowntimer.Start();

            a = random.Next(0, 11);
            label2.Text = a.ToString();

            b = random.Next(0, 11);
            label4.Text = b.ToString();
        }

        private void countdowntimer_Tick(object sender, EventArgs e)
        {
            timerlabel.Text = second--.ToString();

            if (second < 0)
            {
                countdowntimer.Stop();
                var new3 = new gameover();
                new3.Show();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            highscore = Int32.Parse(highscorelabel.Text);
            answer = a * b;
            if (int.TryParse(Useranswer.Text, out useranswer))
            {
                if (useranswer == answer)
                {

                    second = 10;
                    a = random.Next(0, 11);
                    label2.Text = a.ToString();

                    b = random.Next(0, 11);
                    label4.Text = b.ToString();

                    score += 10;

                    scorelabel.Text = score.ToString();


                    Useranswer.Clear();

                }
                else
                {
                    var forms = new gameover();
                    this.Hide();
                    forms.Show();
                    countdowntimer.Stop();
                }




                if (score > highscore)
                {
                    highscorelabel.Text = score.ToString();
                    Properties.Settings.Default.h_score = highscorelabel.Text;
                    Properties.Settings.Default.Save();
                }

                averagepoint = 300;

                if (score == averagepoint)
                {
                    second = 30;
                    a = random.Next(0, 99);
                    label2.Text = a.ToString();

                    b = random.Next(0, 99);
                    label4.Text = b.ToString();

                    score += 15;

                    scorelabel.Text = score.ToString();
                }
                highpoint = 600;

                if (score == highpoint)
                {
                    second = 60;
                    a = random.Next(0, 999);
                    label2.Text = a.ToString();

                    b = random.Next(0, 999);
                    label4.Text = b.ToString();

                    score += 10;

                    scorelabel.Text = score.ToString();
                }



            }




        }

        private void Useranswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button12.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}

