using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Ventas
    {
        private int _idVenta;
        private int _Factura;
        private int _idCliente;
        private string _Cliente;
        private decimal _Subtotal;
        private decimal _IVA;
        private decimal _Total;
        private DateTime _Fecha;

        public int idVenta
        { get { return _idVenta; ; } set { _idVenta= value; } }

        public int Factura
        { get { return _Factura; } set { _Factura = value; } }

        public int idCliente
        { get { return _idCliente; } set { _idCliente = value; } }

        public string Cliente
        { get { return _Cliente; } set { _Cliente = value; } }

        public decimal Subtotal
        { get { return _Subtotal; } set { _Subtotal = value; } }

        public decimal IVA
        { get { return _IVA; } set { _IVA = value; } }

        public decimal Total
        { get { return _Total; } set { _Total = value; } }

        public DateTime Fecha
        { get { return _Fecha; } set { _Fecha = value; } }
    }
}
