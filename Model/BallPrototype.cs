using Caso2.model;
using System.Collections.Generic;
using System.Drawing;

namespace Caso2.Model
{
    public class BallPrototype: IStrategy
    {
        Ball ballPrototype;

        public BallPrototype()
        {
            this.ballPrototype = new Ball(180, Brushes.Yellow);
        }
        List<Ball> IStrategy.generate(int numberOfBalls)
        {
            List<Ball> result = new List<Ball>();
            for(int i = 0;i< numberOfBalls; i++)
            {
                result.Add(ballPrototype.Clone());
            }
            return result;
        }
    }
}
