using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGamev8
{
    public class Apple
    {
        public Rectangle Postions { get; private set; }
        private int Applesize = 20;
        private Random random = new Random();

        public Apple()
        {
            Respawn();
        }
        /// <summary>
        /// Draws a new apple at random x and y
        /// </summary>
        public void Respawn()
        {
            int x = random.Next(0, Applesize) * Applesize;
            int y = random.Next(0, Applesize) * (Applesize - 1);
            
            Postions = new Rectangle(x, y, Applesize, Applesize);
        }
 
           
    }
}
