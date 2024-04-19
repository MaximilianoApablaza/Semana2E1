using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1n
{
    internal class Rectangulo : Figura
    {
        public float large;
        public float height;
        public Rectangulo(float large, float height)
        {
            this.large = large;
            this.height = height;
        }

        public override float area()
        {
            return large * height;
        }
    }


}
