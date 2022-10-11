using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8;
        int gravity = 5;
        int gravity2 = 5;
        int score = 0;
        int p = 0;
        int lifenumber = 3;
        int rnd=0;
        public Form1()
        {
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            if (p == 0)
            {
                highest_score.Text = "Highest score: " + Properties.Settings.Default.score;
                p++;
            }
            if ((score % 12 == 3))
            {
                candy.Location = loc2.Location;
                candy.Visible = true;

            }
            if (score % 12 == 3)
            {
                Random random = new Random();
                rnd = random.Next(0, 2);
                misteryBox.Location = mistry_location.Location;
                misteryBox.Visible = true;

            }
            if (misteryBox.Visible == true)
            {
                misteryBox.Left -= pipeSpeed;
                misteryBox.Top -= 2;
            }

            if (FlappyBird.Bounds.IntersectsWith(misteryBox.Bounds) || (flappy2.Visible==true && flappy2.Bounds.IntersectsWith(misteryBox.Bounds)))
            {
                switch (rnd)
                {
                    case 0:
                        score += 10;
                        break;
                    case 1:
                        pipeSpeed += 30;
                        break;
                    case 2:
                        if (TNT.Visible == false)
                        {
                            TNT.Location = loc.Location;
                            TNT.Visible = true;
                        }
                        break;
                }
                misteryBox.Visible=false;
            }
            if (score % 13 == 2)
            {
                
                TNT.Location = loc.Location;
                TNT.Visible = true;

            }
            if (candy.Visible == true)
            {
                candy.Left -= pipeSpeed;
                candy.Top -= 2;
            }
            if (TNT.Visible == true)
            {
                TNT.Left -= pipeSpeed;
                TNT.Top -= 2;
            }
            if (PipeBottom.Bounds.Y>373)
                PipeBottom.Top -= 1;
            else 
            {
                while(PipeBottom.Bounds.Y <426)
                PipeBottom.Top += 1;
            }
            FlappyBird.Top += gravity;
            PipeBottom.Left -= pipeSpeed;
            PipeTop.Left -= pipeSpeed;
            pipeTop2.Left -= pipeSpeed;
            pipeBottom2.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;
            if (flappy2.Visible == true)
            {
                flappy2.Top += gravity2;
            }
            else
                gravity2 = 5;
            if (PipeBottom.Left < -80)
            {
                if (PipeTop.Top < 110)
                    PipeTop.Top += 10;
                else
                    PipeTop.Top -= 30;
                PipeBottom.Left = 950;
                score++;
                pipeSpeed++;
            }
            if (pipeBottom2.Left < -80)
            {
                if (pipeTop2.Top < 110)
                {
                    pipeTop2.Left += 10;
                }
                else
                    pipeTop2.Left -= 30;
                pipeBottom2.Left = 950;
                score++;
            }
            if (PipeTop.Left < -80)
            {
                if (PipeBottom.Left < 150)
                    PipeBottom.Left += 10;
                else
                    PipeBottom.Left -= 30;
                PipeTop.Left = 950;
                score++;
                pipeSpeed++;
            }
            if (pipeTop2.Left < -50)
            {
                if (pipeBottom2.Top < 110)
                    pipeBottom2.Left += 10;
                else
                    pipeBottom2.Left -= 30;
                pipeTop2.Left = 800;
                score++;
                pipeSpeed++;
            }

            if (FlappyBird.Bounds.IntersectsWith(PipeTop.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(Ground.Bounds) || FlappyBird.Bounds.IntersectsWith(pipeBottom2.Bounds))
            {
                FlappyBird.Location = flappyLocation.Location;
                life();
            }
            if (FlappyBird.Bounds.IntersectsWith(PipeBottom.Bounds) || FlappyBird.Bounds.IntersectsWith(pipeTop2.Bounds))
            {
                FlappyBird.Location = flappyLocation.Location;

                life();
            }

            if (FlappyBird.Top < -25)
            {
                FlappyBird.Location = flappyLocation.Location;
                life();
            }
            if (flappy2.Top < -25)
                flappy2.Visible = false;

            if (FlappyBird.Bounds.IntersectsWith(candy.Bounds) && candy.Visible == true)
            {
                score += 10;
                candy.Visible = false;
                flappy2.Location = new Point(221, 305);
                flappy2.Visible = true;
            }
            if (flappy2.Bounds.IntersectsWith(PipeBottom.Bounds)
               || flappy2.Bounds.IntersectsWith(PipeTop.Bounds) ||
                flappy2.Bounds.IntersectsWith(Ground.Bounds) || flappy2.Bounds.IntersectsWith(pipeTop2.Bounds) || flappy2.Bounds.IntersectsWith(pipeBottom2.Bounds))
            {
                flappy2.Visible = false;
                pipeSpeed = 10;

            }
            if (FlappyBird.Bounds.IntersectsWith(TNT.Bounds) && TNT.Visible == true)
            {
                TNT.Visible = false;
                life();
            }
            if (flappy2.Bounds.IntersectsWith(TNT.Bounds) && flappy2.Visible == true)
            {

                TNT.Visible = false;
                flappy2.Visible = false;
                pipeSpeed = 10;
            }

        }
        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Space)
                gravity = -5;
            if (e.KeyCode == Keys.Up)
                gravity2 -= 5;
        }

        private void gameKeyUP(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = 3;
            if (e.KeyCode == Keys.Up)
                gravity2 = 3;
        }
        private void endGame()
        {
            gameTimer.Stop();
            if (Properties.Settings.Default.score < score)
            {
                Properties.Settings.Default.score = score;
                Properties.Settings.Default.Save();
            }
            MessageBox.Show("Game Over ");
            this.Hide();
            RestartGame restartGame = new RestartGame();
            restartGame.Show();
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            pipeSpeed += 200;
        }
        private void life()
        {
            if (flappy2.Visible == true)
                flappy2.Visible = false;
            else
            {
                switch (lifenumber)
                {


                    case 0:
                        endGame();
                        break;
                    case 1:
                        {
                            life1.Visible = false;
                            lifenumber--;

                            break;
                        }
                    case 2:
                        {
                            lifenumber--;
                            life2.Visible = false;
                            break;
                        }
                    case 3:
                        life3.Visible = false;
                        lifenumber--;
                        break;
                }
            }
            pipeSpeed = 10;

        }

    }
}

