using Caso2.model;
using System;
using System.Drawing;
using System.Numerics;

namespace Caso2.Model
{
    class Ball:IPrototype<Ball>
    {
        public float Speed { get; set; }
        public Vector2 Direction {  get; set; }
        public Brush Color {  get; set; }  

        public Size Size {  get; set; }

        public Ball(int grades,Brush color)
        {
            this.Speed = 2;
            this.Direction = new Vector2((float)Math.Cos(grades), (float)Math.Sin(grades));
            this.Size = new Size(10, 10);
            this.Color = color;
        }

        public Ball(float speed, Vector2 direcction, Size size, Brush color)
        {
            this.Speed = speed;
            this.Direction = new Vector2(direcction.X,direcction.Y);
            this.Size = new Size(size.Width,size.Height);
            this.Color = color;
        }

        public class BallBuilder
        {
            public float Speed { get; set; }
            public Vector2 Direction { get; set; }
            public Brush Color { get; set; }

            public Size Size { get; set; }

            static BallBuilder()
            {

            }

            public BallBuilder setSpeed(float speed)
            {
                this.Speed = speed; 
                return this;
            }
            public BallBuilder setDirection(Vector2 direcction)
            {
                this.Direction = direcction;
                return this;
            }
            public BallBuilder setSize(Size size)
            {
                this.Size = size;
                return this;
            }
            public BallBuilder setColor(Brush color)
            {
                this.Color = color;
                return this;
            }

            public Ball build()
            {
                return new Ball(this.Speed, this.Direction, this.Size,this.Color);
            }

        }

        public Ball Clone()
        {
            return new Ball(this.Speed, this.Direction, this.Size, this.Color);
        }

        public Ball DeepClone()
        {
            return Clone();
        }
    }
}
