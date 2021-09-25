using Caso2.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso2.Model
{
    class BallBuilder : IStrategy/*, IBuilder<List<Ball>>*/
    {
        List<Ball> listBalls;
        public List<Ball> generate(int numberOfBalls)
        {
            return build(numberOfBalls);
        }

        
        public List<Ball> build(int numberOfBalls)
        {
            for (int i = 0; i < numberOfBalls; i++)
            {
                listBalls.Add(new Ball(90, Brushes.Gray));
            }
            List<Ball> newList = listBalls;
            this.reset();
            return newList;
        }

        public void reset()
        {
            this.listBalls = new List<Ball>();
        }
    }
}
