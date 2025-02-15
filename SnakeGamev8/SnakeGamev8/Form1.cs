using System.Windows.Forms;

namespace SnakeGamev8
{
    public partial class Form1 : Form
    {
        private GameManger gamemanager;
        private System.Windows.Forms.Timer Timer;

        public Form1()
        {
            InitializeComponent();

            gameTimer.Interval = 1000;
            gameTimer.Tick += gameTimer_Tick;
            gameTimer.Start();
        }
        private void GameInstructions()
        {

        }
        /// <summary>
        /// Closes application after confirmation from user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonQuit_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to quit Snake Game ?", "Quit Snake Game !", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Continue Playing");
                }

            }
            catch
            {
                MessageBox.Show(" Error: Quit Button ");
            }
        }
        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            gamemanager.ChangeDirection(e.KeyCode);
        }
        private void OnKeyUp(object sender, KeyEventArgs e)
        {

        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (!gamemanager.Update())
            {
                gameTimer.Stop();
                buttonStart.Enabled = true;
                MessageBox.Show("Game Over! Final Score: " + gamemanager.Score);
            }
            pictureBoxDisplay.Invalidate();
        }

        private void UpadateGraphics(object sender, PaintEventArgs e)
        {
            gamemanager.Draw(e.Graphics);
        }
        /// <summary>
        /// Displays the Score
        /// </summary>
        /// <param name="score"></param>
        private void UpdateScore(int score)
        {
            labelScore.Text = "Score: " + score;
        }
        private void UpdateHighScore(int HighestScore)
        {
            labelHighScore.Text = "High Score: " + HighestScore;
        }
        /// <summary>
        /// Starts Game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            gamemanager = new GameManger(UpdateScore);
            gameTimer.Start();
            buttonStart.Enabled = false;
        }

    }
}
