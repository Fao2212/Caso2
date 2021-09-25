using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso2.Model
{
    interface IPrototype<T>
    {
        T clone();
        /*List<T> deepClone();*/
    }
}
