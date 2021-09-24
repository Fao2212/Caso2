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

        public Ball()
        {
            this.Speed = 3;
            this.Direction = new Vector2(1, 1);
            this.Size = new Size(10, 10);
            this.Color = Brushes.Red;
        }

    }
}
