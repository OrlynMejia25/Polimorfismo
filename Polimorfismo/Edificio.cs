using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Edificio
    {
        public string Tipo { get; set; }

        public double Precio { get; set; }

        public void Vender()
        {
            Console.WriteLine($"{Tipo} vendida por el precio de L{Precio}");
        }
    }
}
