using Caso2.model;
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
        IStrategy strategy;

        public Controller()
        {
            //strategy = new BallFactory();
            strategy = new BallPool();
            Balls = strategy.generate(20);   
        }


    }

}
