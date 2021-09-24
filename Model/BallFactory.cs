using Caso2.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso2.Model
{
    class BallFactory : IStrategy
    {
        public List<Ball> generate(int numberOfBalls)
        {
           List<Ball> result = new List<Ball>();    
           for (int i = 0; i < numberOfBalls; i++)
            {
               result.Add( get(BallType.CommonBall)); 
            }
            return result;
        }

        public Ball get(BallType type)
        {
            switch(type) {
                case BallType.CommonBall: return new Ball(90,Brushes.Red);
                default: return null;
            }
        }

        public enum BallType{
            CommonBall
        }
    }
}
