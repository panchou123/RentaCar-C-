using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entities;

namespace Negocio
{
    public class Almacen
    {
        public List<Entities.Almacen> SelectAlmacen()
        {
            AlmacenDataContext dblib = new AlmacenDataContext();
            ProductosDataContext dblibb = new ProductosDataContext();
            var q = from U in dblib.sp_ConsultaAlmacen()
                    join B in dblibb.sp_ConsultaProductos() on U.Id_Producto equals B.Id_Producto
                    select new Entities.Almacen
                    {
                        idAlmacen= (int)U.Id_A,
                        idProducto = (int)U.Id_Producto,
                        Producto = B.Producto,
                        Cantidad = U.Cantidad,
                        Fecha = U.Fecha
                    };
            return q.ToList();
        }

        public List<Entities.Almacen> SelectStock(int id)
        {
            AlmacenDataContext dblib = new AlmacenDataContext();
            var q = from U in dblib.sp_ConsultaStock(id)
                    select new Entities.Almacen
                    {
                        Cantidad = U.Cantidad
                    };
            return q.ToList();
        }

        public List<Entities.Almacen> ReduceStock(int id, int cant)
        {
            AlmacenDataContext dblib = new AlmacenDataContext();
            var q = from U in dblib.sp_ReduceStock(id,cant)
                    select new Entities.Almacen
                    {
                        idProducto = (int)U.Id_Producto,
                        Cantidad = U.Cantidad
                    };
            return q.ToList();
        }
        public void EliminarAlmacen(int id)
        {
            AlmacenDataContext dblib = new AlmacenDataContext();
            dblib.sp_EliminarDeAlmacen(id);
            dblib.SubmitChanges();
        }

        public void InsertarAlmacen(int id, int idp, int cantidad, DateTime FReg)
        {
            AlmacenDataContext dblib = new AlmacenDataContext();
            dblib.sp_InsertayModificaAlmacen(id, idp, cantidad, FReg);
            dblib.SubmitChanges();
        }

    }
}
