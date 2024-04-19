using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1n
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            while (repeat)


            {

                Console.WriteLine("¿Que figura desea calcular? Cuadrado(1) - Rectangulo(2) - Triangulo(3)- Circulo(4)");
                int z = int.Parse(Console.ReadLine());

                switch (z) 
                {
                    case 1: Console.WriteLine("Introducir el largo del cuadrado");
                            int large1 = int.Parse(Console.ReadLine());
                            Figura Cuadrado1 = new Cuadrado(large1);
                            Console.WriteLine("El area del cuadrado es : " + Cuadrado1.area());
                        break;
                    case 2:
                            Console.WriteLine("Introducir el largo del rectangulo");
                            int large2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Introducir la altura del rectangulo");
                            int height2 = int.Parse(Console.ReadLine());
                            Figura Rectangulo1 = new Rectangulo(large2, height2);
                            Console.WriteLine("El area del Rectangulo es : " + Rectangulo1.area());
                        break;
                    case 3:
                        Console.WriteLine("Introducir el largo del triangulo");
                        int large3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introducir la altura del triangulo");
                        int height3 = int.Parse(Console.ReadLine());
                        Figura Triangulo3 = new Triangulo(large3, height3);
                        Console.WriteLine("El area del Triangulo es : " + Triangulo3.area());
                        break;
                    case 4:
                        Console.WriteLine("Introducir el radio del circulo");
                        int large4 = int.Parse(Console.ReadLine());
                        Figura Circulo1 = new Circulo(large4);
                        Console.WriteLine("El area del Circulo es : " + Circulo1.area());
                        break;
                }
                Console.WriteLine("¿Quieres continuar? si/no");
                string x = Console.ReadLine();
                if(x == "si") 
                { 

                }
                else
                {
                    repeat = false;
                }

            }
        }
    }
}
