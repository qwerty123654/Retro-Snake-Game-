using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGamev8
{
    public class Snake
    {
        public List<Rectangle> body {  get; set; }
        private int SnakeSize = 20;
        private Point direction; 

        public Snake() 
        {
            body =  new List<Rectangle> { new Rectangle(250, 250,SnakeSize,SnakeSize) };
            direction = new Point(SnakeSize, 0);
        }

        public void Move()
        {
            Rectangle newHead = new Rectangle(body[0].X + direction.X, body[0].Y + direction.Y,SnakeSize, SnakeSize);
            body.Insert(0, newHead);
            body.RemoveAt(body.Count - 1);
        }
        public void Grow()
        {
            body.Add(new Rectangle(body[^1].Location, new Size(SnakeSize,SnakeSize)));
        }
        /// <summary>
        /// Reads key strokes from the keyboard and lets user contol the snake
        /// </summary>
        /// <param name="key"></param>
        public void ChangeDirection(Keys key)
        {
            //Up and down movement of snake control
            if ((key == Keys.Up || key == Keys.W) && direction.Y == 0)
            {
                direction = new Point(0, -SnakeSize);
            }
            if ((key == Keys.Down || key == Keys.S) && direction.Y == 0)
            {
                direction = new Point(0, SnakeSize);
            }
            //Left and right movement of snake ocntrol
            if ((key == Keys.Left || key == Keys.A) && direction.X == 0)
            {
                direction = new Point(-SnakeSize, 0);
            }
            if ((key == Keys.Right || key == Keys.D) && direction.X == 0)
            {
                direction = new Point(SnakeSize, 0);
            }

        }

        /// <summary>
        /// Checks the body segments and looks for contact with another square if a collision ocurs then the object with return true else it will stay false
        /// </summary>
        /// <returns></returns>
        public bool CheckforCollisions()
        {
            for (int i = 0; i < body.Count; i++)
            {
                if (body[0].IntersectsWith(body[i]))
                    return true;
            }
            return false;
        }



    }
}