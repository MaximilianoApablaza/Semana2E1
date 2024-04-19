using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1n
{
    internal class Cuadrado : Figura
    {
        public float large; 
        public Cuadrado(float large)
        {
            this.large = large;
        }

        public override float area()
        {
            return large * large;
        }
    }


}
