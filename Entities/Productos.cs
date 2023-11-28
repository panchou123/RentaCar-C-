using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Productos
    {
        private int _idProducto;
        private String _Producto;
        private decimal _Precio;
        private Boolean _Activo;
        private DateTime _Fecha;

        public int idProducto
        { get{ return _idProducto; } set{ _idProducto = value; } }

        public String Producto
        { get { return _Producto; } set { _Producto = value; } }

        public decimal Precio
        { get { return _Precio; } set { _Precio = value; } }

        public Boolean Activo
        { get { return _Activo; } set { _Activo = value; } }

        public DateTime Fecha
        { get { return _Fecha; } set { _Fecha = value; } }
    }
}
