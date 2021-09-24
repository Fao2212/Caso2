using Caso2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso2.model
{
    interface IStrategy
    {
        List<Ball>generate(int numberOfBalls);
    }
}
