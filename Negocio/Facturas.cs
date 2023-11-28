using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Negocio
{
   public class Facturas
    {
        public List<Entities.Facturas> SelectFactura(int id)
        {
            FacturasDataContext dblib = new FacturasDataContext();
            ProductosDataContext dblibb = new ProductosDataContext();
            var q = from U in dblib.sp_ConsultaFactura(id)
               join B in dblibb.sp_ConsultaProductos() on U.Id_Producto equals B.Id_Producto
                    select new Entities.Facturas
                    {
                        Factura = (int)U.Factura,
                        idProducto = (int)U.Id_Producto,
                        Producto = B.Producto,
                        Cantidad = (int)U.Cantidad,
                        Total = (decimal)U.Total,
                        Fecha = (DateTime)U.Fecha
                    };
            return q.ToList();
        }

        public void InsertarFactura(int Fac, int idP, int cant, decimal sub, DateTime Fe)
        {
            FacturasDataContext dblib = new FacturasDataContext();
            dblib.sp_InsertayModificaFactura(Fac, idP, cant, sub, Fe);
            dblib.SubmitChanges();
        }

        public void EliminaFactura(int id)
        {
            FacturasDataContext dblib = new FacturasDataContext();
            dblib.sp_EliminaFactura(id);
            dblib.SubmitChanges();
        }
        public void CancelaFacturas()
        {
            FacturasDataContext dblib = new FacturasDataContext();
            dblib.sp_CancelaFacturas();
            dblib.SubmitChanges();
        }
    }
}
