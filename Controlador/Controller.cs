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
        Dictionary<StrategyType,IStrategy> strategies;
        Form2 form2;
        int numberOfBalls = 20;

        public Controller()
        {
            this.strategies = new Dictionary<StrategyType, IStrategy>();
            this.strategies[StrategyType.Builder] = new BallBuilder();
            this.strategies[StrategyType.Factory] = new BallFactory();
            this.strategies[StrategyType.Pool] = new BallPool();
            this.strategies[StrategyType.Prototype] = new BallPrototype();
        }

        public void addView(Form2 form2)
        {
            this.form2 = form2;
        }

        public void moreBalls(StrategyType strategy)
        {
            form2.loadBalls(this.strategies[strategy].generate(numberOfBalls));
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
