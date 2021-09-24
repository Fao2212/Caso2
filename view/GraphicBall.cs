using Caso2.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Caso2.view
{
    internal class GraphicBall
    {
        Ball ball;
        Vector2 xRange,yRange,position;
        int offset;

        public GraphicBall(Ball ball,Vector2 xRange,Vector2 yRange,Vector2 position,int offset)
        {
            this.ball = ball;
            this.position = position;
            this.xRange = xRange;
            this.yRange = yRange;
            this.offset = offset;
        }

        public void update()
        {
            if (!inBounds())
            {
                ball.Speed = ball.Speed * -1;
            }
            position += ball.Direction * ball.Speed;
        }

        private bool inBounds()
        {
            return position.X>xRange.X+offset && position.X<xRange.Y-offset&&position.Y>yRange.X+offset&&position.Y<yRange.Y-offset;
        }

        public void display(Graphics e)
        {
            e.FillEllipse(ball.Color, position.X, position.Y, ball.Size.Width, ball.Size.Height);
        }
    }
}
