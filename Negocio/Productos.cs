using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using AccesoDatos;

namespace Negocio
{
    public class Productos
    {
        public List<Entities.Productos> SelectProductos()
        {
            ProductosDataContext dblib = new ProductosDataContext();
            var q = from U in dblib.sp_ConsultaProductos()
                    select new Entities.Productos
                    {
                        idProducto = (int)U.Id_Producto,
                        Producto = U.Producto,
                        Precio = (decimal)U.Precio,
                        Activo = (Boolean)U.Activo,
                        Fecha = (DateTime)U.Fecha
                    };
            return q.ToList();
        }

        public List<Entities.Productos> ConsultaAlmacenExistente(int fac)
        {
            ProductosDataContext dblib = new ProductosDataContext();
            var q = from U in dblib.sp_ConsultaAlmacenExistente(fac)
                    select new Entities.Productos
                    {
                        idProducto = (int)U.Id_Producto,
                        Producto = U.Producto,
                        Precio = (decimal)U.Precio,
                        Activo = (Boolean)U.Activo,
                        Fecha = (DateTime)U.Fecha
                    };
            return q.ToList();
        }

        public void EliminarProducto(int id)
        {
            ProductosDataContext dblib = new ProductosDataContext();
            dblib.sp_EliminarProducto(id);
            dblib.SubmitChanges();
        }

        public void InsertarProducto(int id, string Prod, decimal precio, Boolean Act, DateTime FReg)
        {
            ProductosDataContext dblib = new ProductosDataContext();
            dblib.sp_InsertayModificaProductos(id, Prod, precio , Act, FReg);
            dblib.SubmitChanges();
        }

        public List<Entities.Productos> ProductoNoRegistrado()
        {
            ProductosDataContext dblib = new ProductosDataContext();
            var q = from U in dblib.sp_ConsultaProductosActivosSinRegistrar()
                    select new Entities.Productos
                    {
                        idProducto = (int)U.Id_Producto,
                        Producto = U.Producto
                    };
            return q.ToList();

        }

        public List<Entities.Productos> Precio(int id)
        {
            ProductosDataContext dblib = new ProductosDataContext();
            var q = from U in dblib.sp_ConsultaPrecio(id)
                    select new Entities.Productos
                    {
                        Precio = (decimal)U.Precio
                    };
            return q.ToList();
        }
    }
}
