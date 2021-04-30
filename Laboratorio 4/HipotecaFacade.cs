using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_4
{
    public class HipotecaFacade : IHipotecaFacade
    {
        private readonly IServicioPrestamo _servicioPrestamo;
        private readonly AtencionCliente _atencionCliente;
        private readonly Banco _banco;

        public HipotecaFacade(
            IServicioPrestamo servicioPrestamo,
            AtencionCliente atencionCliente,
            Banco banco)
        {
            _servicioPrestamo = servicioPrestamo;
            _atencionCliente = atencionCliente;
            _banco = banco;
        }

        public bool EstaAprovado(Cliente cliente)
        {
            if (!_atencionCliente.EsUsuarioValido(cliente.Carnet))
                return false;

            if (!_banco.TieneCredito(cliente.Carnet))
                return false;

            if (_servicioPrestamo.TienePrestamo(cliente))
                return false;

            return true;
        }
   
    }
}
