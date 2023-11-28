using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entities;

namespace Negocio
{
    public class Usuarios
    {
        public List<Entities.Usuarios> UsuarioActivo()
        {
            UsuariosDataContext dblib = new UsuariosDataContext();
            var q = from U in dblib.sp_ConsultaUsuariosActivos()
                    select new Entities.Usuarios
                    {
                        idUsuario = (int)U.Id_Usuario,
                        Usuario = U.Usuario,
                        Password = U.Contrasenia
                    };
            return q.ToList();
        }

        public List<Entities.Usuarios> SelectUsuario()
        {
            UsuariosDataContext dblib = new UsuariosDataContext();
            EmpleadosDataContext dblibb = new EmpleadosDataContext();
            var q = from U in dblib.sp_ConsultaUsuarios()
                    join B in dblibb.sp_ConsultaEmpleados() on U.Id_Empleado equals B.Id_emp
                    select new Entities.Usuarios
                    {
                        idUsuario = (int)U.Id_Usuario,
                        idEmpleado = (int)U.Id_Empleado,
                        Empleado = B.Nombre,
                        Usuario = U.Usuario,
                        Password = U.Contrasenia,
                        Fecha = (DateTime)U.Fecha
                    };
            return q.ToList();
        }
        public void InsertarUsuario(int idU, int idE, string Usu, string Pass, DateTime Fe)
        {
            UsuariosDataContext dblib = new UsuariosDataContext();
            dblib.sp_InsertayModificaUsuarios(idU, idE, Usu, Pass, Fe);
            dblib.SubmitChanges();
        }

        public void EliminarUsuario(int idU)
        {
            UsuariosDataContext dblib = new UsuariosDataContext();
            dblib.sp_EliminarUsuarios(idU);
            dblib.SubmitChanges();
        }
        
    }
}
