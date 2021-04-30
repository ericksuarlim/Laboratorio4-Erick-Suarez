using System;
using System.Collections.Generic;

namespace Laboratorio_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            var clientes = new List<Cliente>
        {
            new Cliente("12") { Nombre = "Rosita", Ocupacion = "Secreataria" },
            new Cliente("54") { Nombre = "Luis Erick", Ocupacion = "Desarrollador" }
        };

            var hipoteca = new HipotecaFacade(
                new ServicioPrestamo(),
                new AtencionCliente(),
                new Banco());

            clientes.ForEach(cliente =>
            {
                if (hipoteca.EstaAprovado(cliente))
                    Console.WriteLine("{0}:{1} esta aprovado para prestamo.", cliente.Nombre, cliente.Ocupacion);
                else
                    Console.WriteLine("{0}:{1} no esta aprovado para prestamo.", cliente.Nombre, cliente.Ocupacion);
                Console.WriteLine("--------");
            });

            Console.ReadLine();
        }
    }
}
