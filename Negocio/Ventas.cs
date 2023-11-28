using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Negocio
{
    public class Ventas
    {
       public List<Entities.Ventas> SelectVentas()
        {
            VentasDataContext dblib = new VentasDataContext();
            ClientesDataContext dblibb = new ClientesDataContext();
            var q = from U in dblib.sp_ConsultaVentas()
                    join B in dblibb.sp_ConsultaClientes() on U.Cliente equals B.Id_Cliente               
                    select new Entities.Ventas
                    {
                        idVenta = (int)U.Id_Ventas,
                        Factura = (int)U.Factura,
                        idCliente = (int)U.Cliente,
                        Cliente = B.Cliente,
                        Subtotal = (decimal)U.SubTotal,
                        IVA = (decimal)U.IVA,
                        Total = (decimal)U.Total,
                        Fecha = (DateTime)U.Fecha
                    };
            return q.ToList();
        }

        public void InsertarVenta(int Fac, int idC, decimal sub, decimal IVA, decimal Total,DateTime Fe)
        {
            VentasDataContext dblib = new VentasDataContext();
            dblib.sp_InsertarVenta(Fac, idC,sub, IVA, Total, Fe);
            dblib.SubmitChanges();
        }

        public void EliminarVenta(int idV)
        {
            VentasDataContext dblib = new VentasDataContext();
            dblib.sp_EliminarVenta(idV);
            dblib.SubmitChanges();
        }

        public void EliminarVentaCliente(int idV)
        {
            VentasDataContext dblib = new VentasDataContext();
            dblib.sp_EliminaVentasCliente(idV);
            dblib.SubmitChanges();
        }
    }
}
