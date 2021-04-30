using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_4
{
    public class ServicioPrestamo : IServicioPrestamo
    {
        private HashSet<string> listaBanco = new HashSet<string> { "123", "321" };

        public bool TienePrestamo(Cliente cliente)
        {
            var tienePrestamo = listaBanco.Contains(cliente.Carnet) ||
            cliente.Ocupacion.Equals("Desarrollador", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("El cliente {0}, {1} tiene prestamo en su historial", cliente.Carnet, tienePrestamo ? "Si" : "No");
            return tienePrestamo;
        }

    }
}
