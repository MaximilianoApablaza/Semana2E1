using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1n
{
    internal class Circulo : Figura
    {
        public float radio;
    
        public Circulo(float radio)
        {
            this.radio = radio;
            
        }

        public override float area()
        {
            return 3.14f * radio * radio;
        }
    }


}

