using Caso2.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Caso2.Model.BallFactory;

namespace Caso2.Model
{
    class BallPool : IStrategy
    {

        Stack<PoolBall> fullStack;
        List<PoolBall> usedStack;
        Stack<PoolBall> freeStack;
        //BallFactory factory;
        int maxBalls = 100;
        int minBalls = 40;
        int timeout = 100;


        public BallPool()
        {
            //factory = new BallFactory();
            fullStack = new Stack<PoolBall>();
            usedStack = new List<PoolBall>();
            freeStack = new Stack<PoolBall>();
            initpool();
        }
        
        public List<Ball> generate(int numberOfBalls)
        {
            List<Ball> result = new List<Ball>();
            for (int i = 0; i < numberOfBalls; i++)
            {
                result.Add(getObject());
            }
            return result;
        }

        class PoolBall
        {
            public Ball Ball { get; set; }
            public bool Used {  get;set; }

            public PoolBall(Ball ball)
            {
                Ball = ball;
                Used = false;
            }
            public void marcar()
            {
                Used = !Used;
            }
        }

        void initpool()
        {
            
            for (int i = 0;i< minBalls; i++)
            {
                //Ball ball = factory.get(BallType.CommonBall);
                //fullStack.Push(new PoolBall(ball));
                fullStack.Push(new PoolBall(new Ball(76, Brushes.Blue)));
            }
            
        }
        Ball getObject()
        {
            if(freeStack.Count > 0)
            {
                PoolBall ball = freeStack.Pop();
                usedStack.Add(ball);
                return ball.Ball;
            }
            else if (freeStack.Count < maxBalls)
            {
                //PoolBall ball= new PoolBall(factory.get(BallType.CommonBall));
                PoolBall ball = new PoolBall(new Ball(76,Brushes.Blue));
                fullStack.Push(ball);
                usedStack.Add(ball);
                return ball.Ball;
            }
            else{
                waitForResource();
                return getObject();
            }
        }
            //Conexiones libres? Pop y se tiene el first se marca como utilizado se mete a lista de utilizados y se retorna la referencia
            //Si no hay suficientes entonces cree tantas bolas como permita el maximo y si ya se pasa del maximo entonces setear un time out
        void waitForResource()
        {
            while(fullStack.Count < 0)
            {
                //Timer timer
            }
        }
       
        void releaseObject(PoolBall toRelease)
        {
           usedStack.Remove(toRelease); 
           freeStack.Push(toRelease);
        }
        
    }
}
