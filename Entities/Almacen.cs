using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Almacen
    {
        private int _idAlmacen;
        private int _idProducto;
        private string _Producto;
        private int _Cantidad;
        private DateTime _Fecha;

        public int idAlmacen
        { get { return _idAlmacen; } set { _idAlmacen = value; } }

        public int idProducto
        { get { return _idProducto; } set { _idProducto = value; } }

        public string Producto
        { get { return _Producto; } set { _Producto = value; } }

        public int Cantidad
        { get { return _Cantidad; } set { _Cantidad = value; } }

        public DateTime Fecha
        { get { return _Fecha; } set { _Fecha = value; } }
    }
}
