using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGamev8
{
    public class GameManger
    {
        private Snake snake;
        private Apple apple;

        public int Score {  get; private set; }
        public int HighScore { get; private set; }

        private Action<int> updateScore;


        public GameManger(Action<int> updateScoreAction)
        {
            snake = new Snake();
            apple = new Apple();
            Score = 0;
            HighScore = 0;
            updateScore = updateScoreAction;
            
        }

       

        /// <summary>
        /// Compares high score with current score to 
        /// </summary>
        public void HighScoreUpdate()
        {
            if (Score == HighScore || Score < HighScore)
            {
                HighScore = Score;
            }
            else if (Score > HighScore)
            {
                Score = HighScore;
            }
        }

        public bool Update()
        {
            snake.Move();
            if (snake.body[0].X < 0 || snake.body[0].X >= 400 || snake.body[0].Y < 0 || snake.body[0].Y >= 400 || snake.CheckforCollisions())
            {
                HighScoreUpdate();
                return false;
            }
            if (snake.body[0].IntersectsWith(apple.Postions))
            {
                snake.Grow();
                apple.Respawn();
                Score += 1;
                updateScore(Score);
            }
            return true;
        }

        public void ChangeDirection(Keys keys)
        {
            snake.ChangeDirection(keys);
        }

        public void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Red, apple.Postions);
            foreach( var part in snake.body)
            {
                g.FillRectangle(Brushes.Green, part);
            }
        }

        public enum Directions
        {
            left, right, top, bottom
        }
    }
}
