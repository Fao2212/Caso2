using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Caso2.Model
{
    class Ball
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

        public Ball clone()
        {
            return (Ball)this.MemberwiseClone();
        }

    }
}
