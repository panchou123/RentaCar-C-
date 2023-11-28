using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Facturas
    {
        private int _Factura;
        private int _idProducto;
        private string _Producto;
        private int _Cantidad;
        private decimal _Total;
        private DateTime _Fecha;

        public int Factura
        { get { return _Factura; } set { _Factura = value; } }

        public int idProducto
        { get { return _idProducto; } set { _idProducto = value; } }

        public string Producto
        { get { return _Producto; } set { _Producto = value; } }

        public int Cantidad
        { get { return _Cantidad; } set { _Cantidad = value; } }

        public decimal Total
        { get { return _Total; } set { _Total = value; } }

        public DateTime Fecha
        { get { return _Fecha; } set { _Fecha = value; } }
    }
}
