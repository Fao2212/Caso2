using Caso2.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso2.Model
{
    public class BallPrototype: IStrategy/*, IPrototype<Ball>*/
    {
        
        public List<Ball> generate(int numberOfBalls)
        {
            List<Ball> listBalls = new List<Ball>();
            Ball newBall = new Ball(45, Brushes.Blue);
            for(int i = 0; i < numberOfBalls; i++)
            {
                listBalls.Add(newBall.clone());
            }
            
            return listBalls;
        }
    }
}
