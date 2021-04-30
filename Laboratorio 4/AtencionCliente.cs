using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_4
{
    public class AtencionCliente
    {
        private HashSet<string> esUsuarioActivo = new HashSet<string> { "123" };

        public bool EsUsuarioValido(string idCliente)
        {
            var esValido = !esUsuarioActivo.Contains(idCliente);
            Console.WriteLine("El cliente {0} es {1}", idCliente, esValido ? "valido" : "invalido");
            return esValido;
        }
    }
}
