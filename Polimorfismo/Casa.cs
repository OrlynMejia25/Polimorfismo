﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Casa : Inmueble
    {
        public Casa() { }

        public Casa(string TipoInmueble)
        {
            this.TipoInmueble = TipoInmueble;
        }
    }
}
