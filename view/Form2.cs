using Caso2.Controlador;
using Caso2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caso2.view
{
     partial class Form2 : Form
    {

        private Controller controlador;
        List<GraphicBall> graphicBalls;
        Vector2 xBallRange;
        Vector2 yBallRange;
        int offset = 10;
        public Form2(Controller controlador)
        {
            this.controlador = controlador;
            this.graphicBalls = new List<GraphicBall>();
            InitializeComponent();
            panelBolas.BackColor = Color.Transparent;
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            foreach (GraphicBall ball in graphicBalls)
            {
                ball.update();
                ball.display(e.Graphics);

            }
        }

        internal void loadBalls(List<Ball> balls)
        {
            foreach (Ball ball in balls)
            {
                graphicBalls.Add(new GraphicBall(ball, xBallRange, yBallRange, randomPosition(), this.offset));
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Size size = panelBolas.Size;
            Point location = panelBolas.Location;
            this.xBallRange = new Vector2(location.X, location.X + size.Width);
            this.yBallRange = new Vector2(location.Y, location.Y + size.Height);    
            this.DoubleBuffered = true;
            Timer timer = new Timer();
            timer.Interval = 10;
            timer.Enabled = true;
            timer.Tick += Timer_Tick;
            this.Paint += Form2_Paint;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        public Vector2 randomPosition()
        {

            return new Vector2(new Random().Next((int)xBallRange.X+offset, (int)xBallRange.Y)-offset, new Random().Next((int)yBallRange.X+offset, (int)yBallRange.Y)-offset);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controlador.moreBalls();
        }


    }
}
