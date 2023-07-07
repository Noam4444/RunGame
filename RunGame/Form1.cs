using System.Media;
using Windows.Media.Playback;

namespace RunGame
{
    public partial class Form1 : Form
    {
        // global variables
        int gravity;
        int gravityValue = 8;
        int obstacleSpeed = 10;
        int score = 0;
        int highScore = 0;
        bool gameOver = false;
        Random random = new Random();
        


        public Form1()
        {
            InitializeComponent();
            RestartGame();  
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {

            lblScore.Text = "Score: " + score;
            lblhighScore.Text = "High Score: " + highScore;
            player.Top += gravity;

            // when the player land on the platforms. 
            if (player.Top > 343)
            {
                gravity = 0;
                player.Top = 343;
                player.Image = Properties.Resources.run_down0;
            }
            else if (player.Top < 38)
            {
                gravity = 0;
                player.Top = 38;
                player.Image = Properties.Resources.run_up0;
            }
               // move the obstacles
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;
                    if (x.Left < -100)
                    {
                        x.Left = random.Next(1200, 3000);
                        score += 1;
                    }

                    if (x.Bounds.IntersectsWith(player.Bounds))
                    {
                        gameTimer.Stop();
                        lblScore.Text += " Game Over!! Press Enter to Restart.";
                        gameOver = true;
                        // set the high score 
                        if (score > highScore)
                        {
                            highScore = score;
                        }
                    }
                }
            }
            // increase the speed of player and obstacles
            if (score > 10)
            {
                obstacleSpeed = 25;
                gravityValue = 12;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (player.Top == 343)
                {
                    player.Top -= 10;
                    gravity = -gravityValue;
                }
                else if (player.Top == 38)
                {
                    player.Top += 10;
                    gravity = gravityValue;
                }
            }

            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }
        }
        
        private void RestartGame()
        {
            lblScore.Parent = pictureBox1;
            lblhighScore.Parent = pictureBox2;
            lblhighScore.Top = 0;
            player.Location = new Point(180, 149);
            player.Image = Properties.Resources.run_down0;
            score = 0;
            gravityValue = 8;
            gravity = gravityValue;
            obstacleSpeed = 10;
            

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left = random.Next(1200, 3000);
                }
            }

            gameTimer.Start();

        }
    }
}