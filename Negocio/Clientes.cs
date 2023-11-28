using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using AccesoDatos;

namespace Negocio
{
    public class Clientes
    {
        public List<Entities.Clientes> SelectClientes()
        {
            ClientesDataContext dblib = new ClientesDataContext();
            var q = from U in dblib.sp_ConsultaClientes()
                    select new Entities.Clientes
                    {
                        idCliente = (int)U.Id_Cliente,
                        Cliente = U.Cliente,
                        Telefono = U.Telefono,
                        Direccion = U.Direccion,
                        Correo = U.Correo,
                        Fecha = (DateTime)U.Fecha
                    };
            return q.ToList();
        }
        public void InsertarCliente(int idC, string cli, string tel, string dir, string corr, DateTime Fe)
        {
            ClientesDataContext dblib = new ClientesDataContext();
            dblib.sp_InsertayModificaClientes(idC, cli, tel, dir, corr, Fe);
            dblib.SubmitChanges();
        }

        public void EliminarCliente(int idC)
        {
            ClientesDataContext dblib = new ClientesDataContext();
            dblib.sp_ElieminarCliente(idC);
            dblib.SubmitChanges();
        }

    }
}
