using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Clientes
    {
        private int _idCliente;
        private string _Cliente;
        private string _Telefono;
        private string _Direccion;
        private string _Correo;
        private DateTime _Fecha;

        public int idCliente
        { get { return _idCliente ; } set { _idCliente = value; } }
        public string Cliente
        { get { return _Cliente; } set { _Cliente = value; } }

        public string Telefono
        { get { return _Telefono; } set { _Telefono = value; } }

        public string Direccion
        { get { return _Direccion; } set { _Direccion = value; } }

        public string Correo
        { get { return _Correo; } set { _Correo = value; } }

        public DateTime Fecha
        { get { return _Fecha; } set { _Fecha = value; } }
    }
}
