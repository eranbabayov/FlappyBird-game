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
        int score = 0;
        int p = 0;
/*        static int bomb,candyy;
*/        public Form1()
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
                candy.Location = new Point(1032, 326);
                candy.Visible = true;

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
            FlappyBird.Top += gravity;
            PipeBottom.Left -= pipeSpeed;
            PipeTop.Left -= pipeSpeed;
            pipeTop2.Left -= pipeSpeed;
            pipeBottom2.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;
            if(flappy2.Visible == true)
            {
                flappy2.Top += gravity;               
            }
            if (PipeBottom.Left < -50)
            {
                if (PipeBottom.Top < 110)
                    PipeBottom.Top += 10;
                else
                    PipeBottom.Top -= 30;
                PipeBottom.Left = 800;

                score++;
                pipeSpeed++;
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
            if (pipeTop2.Left < -80)
            {
                if (pipeBottom2.Left <150)
                    pipeBottom2.Left += 50;
                else
                    pipeBottom2.Left -= 30;
                pipeTop2.Left = 950;
                score++;
                pipeSpeed++;
            }

            if (pipeBottom2.Left<-80)
            {
                if (pipeBottom2.Top < 110)
                {
                    pipeBottom2.Top += 5;
                }

                else
                    pipeBottom2.Top -= 5;
                pipeBottom2.Left = 800;
                score++;
            }

            if (FlappyBird.Bounds.IntersectsWith(PipeBottom.Bounds)
               || FlappyBird.Bounds.IntersectsWith(PipeTop.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(Ground.Bounds) || FlappyBird.Bounds.IntersectsWith(pipeTop2.Bounds) || FlappyBird.Bounds.IntersectsWith(pipeBottom2.Bounds))
            {
                endGame();
            }
            if (FlappyBird.Top < -25)
            {
                endGame();
            }
            if (flappy2.Top < -25)
                flappy2.Visible = false;

                if (FlappyBird.Bounds.IntersectsWith (candy.Bounds) && candy.Visible==true)
                {
                   score += 10;
                   candy.Visible = false;
                   flappy2.Location = new Point(221, 305);
                   flappy2.Visible = true;
            }
            if (flappy2.Bounds.IntersectsWith(PipeBottom.Bounds)
               || flappy2.Bounds.IntersectsWith(PipeTop.Bounds) ||
                flappy2.Bounds.IntersectsWith(Ground.Bounds) || flappy2.Bounds.IntersectsWith(pipeTop2.Bounds) || flappy2.Bounds.IntersectsWith(pipeBottom2.Bounds))
                flappy2.Visible=false;
                if (FlappyBird.Bounds.IntersectsWith(TNT.Bounds) && TNT.Visible == true)
            {
                endGame();  
            }
            if (flappy2.Bounds.IntersectsWith(TNT.Bounds) && flappy2.Visible == true)
            {
                flappy2.Visible = false;
                TNT.Visible = false;
            }

        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = -5;
        }

        private void gameKeyUP(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = 3;
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

    }
}
