﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Departamento : Inmueble
    {
        public Departamento() { }

        public Departamento(double Precio)
        {
            this.Precio = Precio;
        }
    }
}
