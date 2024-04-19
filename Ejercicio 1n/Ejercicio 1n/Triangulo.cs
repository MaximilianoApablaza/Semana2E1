using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1n
{
    internal class Triangulo : Figura
    {
        public float large;
        public float height;
        public Triangulo(float large, float height)
        {
            this.large = large;
            this.height = height;
        }

        public override float area()
        {
            return large * height /2;
        }
    }


}

