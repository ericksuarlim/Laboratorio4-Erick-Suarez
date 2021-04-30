using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_4
{
    public class Banco
    {
        private HashSet<string> listaBanco = new HashSet<string> { "123" };

        public bool TieneCredito(string idCliente)
        {
            var tieneCredito = !listaBanco.Contains(idCliente);
            Console.WriteLine("El cliente {0}, {1} tiene credito", idCliente, tieneCredito ? "Si" : "No");
            return tieneCredito;
        }
    }
}
