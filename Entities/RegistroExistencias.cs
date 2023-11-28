using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RegistroExistencias
    {
        private int _id;
        private int _idProducto;
        private int _CantidadExistente;
        private int _CantidadAjuste;
        private Boolean _Venta;
        private Boolean _Compra;
        private DateTime _Fecha;

        public int id
        { get { return _id; } set { _id = value; } }

        public int idProducto
        { get { return _idProducto; } set { _idProducto = value; } }

        public int CantidadExistente
        { get { return _CantidadExistente; } set { _CantidadExistente = value; } }

        public int CantidadAjuste
        { get { return _CantidadAjuste; } set { _CantidadAjuste = value; } }

        public Boolean Venta
        { get { return _Venta; } set { _Venta = value; } }

        public Boolean Compra
        { get { return _Compra; } set { _Compra = value; } }

        public DateTime Fecha
        { get { return _Fecha; } set { _Fecha = value; } }
    }
}
