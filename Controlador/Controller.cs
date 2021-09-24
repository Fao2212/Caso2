using Caso2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso2.Controlador
{
     class Controller
    {
        public List<Ball> Balls { get; set; }

        public Controller()
        {
            // balls = strategy.createBalls();
            Balls = new List<Ball>();
            for(int i = 0; i < 20; i++)
            {
                Ball ball = new Ball();
                Balls.Add(ball);
            }
            
        }


    }

}
