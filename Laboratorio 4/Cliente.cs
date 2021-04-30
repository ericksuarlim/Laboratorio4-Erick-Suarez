using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_4
{
    public class Cliente
    {
        public string Carnet { get; private set; }
        public string Nombre { get; set; }
        public string Ocupacion { get; set; }

        public Cliente(string carnetIn)
        {
            Carnet = carnetIn;
        }

     
    }
}
