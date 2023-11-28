using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using AccesoDatos;

namespace Negocio
{
    public class Empleados
    {
        public List<Entities.Empleados> SelectEmpledos()
        {
            EmpleadosDataContext dblib = new EmpleadosDataContext();
            var q = from U in dblib.sp_ConsultaEmpleados()
                    select new Entities.Empleados
                    {
                        idEmpleado = (int)U.Id_emp,
                        Nombre = U.Nombre,
                        Genero = U.Genero,
                        Foto = U.Foto,
                        Puesto = U.Puesto,
                        Activo = U.Activo,
                        FechaRegistro = U.Fecha,
                        FechaNacimiento = (DateTime)U.F_Nac
                    };
            return q.ToList();
        }
        public void EliminarEmpledos(int id)
        {
            EmpleadosDataContext dblib = new EmpleadosDataContext();
            dblib.sp_EliminarEmpleado(id);
            dblib.SubmitChanges();
        }

        public void AgregarEmpledos(int id, string Nom, string Gen, string Fot, string Pue, Boolean Act, DateTime FReg, DateTime FNac)
        {
            EmpleadosDataContext dblib = new EmpleadosDataContext();
            dblib.sp_InsertayModificaEmpleados(id,Nom,Gen,Fot,FNac,Pue,Act,FReg);
            dblib.SubmitChanges();
        }
        public List<Entities.Empleados> EmpleadoNoUsuario()
        {
            EmpleadosDataContext dblib = new EmpleadosDataContext();
            var q = from U in dblib.sp_ConsultaEmpleadosSinUsuario()
                    select new Entities.Empleados
                    {
                        idEmpleado = (int)U.Id_emp,
                        Nombre = U.Nombre
                    };
            return q.ToList();

        }
    }
}
