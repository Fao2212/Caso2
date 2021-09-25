using Caso2.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Caso2.Model
{
    class BallBuilder : IStrategy/*, IBuilder<List<Ball>>*/
    {

        int defaultSize = 10;

        public List<Ball> generate(int numberOfBalls)
        {
            List<Ball> result = new List<Ball>();
            for (int i = 0; i < numberOfBalls; i++)
            {
                result.Add(buildBall());   
            }
            return result;
        }


        public Ball buildBall()
        {
            return new Ball.BallBuilder().setSize(new Size(defaultSize,defaultSize)).setDirection(new Vector2(1,0)).setSpeed(5).setColor(Brushes.Green).build();
        }
    }
}
