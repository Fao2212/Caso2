using Caso2.model;
using Caso2.Model;
using Caso2.view;
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
        Form2 form2;
        int numberOfBalls = 20;

        public Controller()
        {
            this.strategy = new BallBuilder();

        }

        public void addView(Form2 form2)
        {
            this.form2 = form2;
        }

        public void moreBalls()
        {
            form2.loadBalls(this.strategy.generate(numberOfBalls));
        }

        public enum StrategyType
        {
            Factory,
            Pool,
            Builder,
            Prototype
        }

    }

}
