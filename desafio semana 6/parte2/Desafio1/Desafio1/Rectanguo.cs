using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    using System;

    class Rectangulo
    {
        
        public double Alto { get; }
        public double Largo { get; }

        
        public double SuperficieFrontal => Alto * Largo;

        
        public Rectangulo(double alto, double largo)
        {
            Alto = alto;
            Largo = largo;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Rectangulo rectangulo = new Rectangulo(30, 60);

            
            Console.WriteLine($"Superficie frontal del rectángulo: {rectangulo.SuperficieFrontal}");
        }
    }

}
