using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Usuarios
    {
        private int _idUsuario;
        private int _idEmpleado;
        private string _Empleado;
        private string _Usuario;
        private string _Password;
        private DateTime _Fecha;

        public int idUsuario
        { get { return _idUsuario; } set { _idUsuario = value; } }

        public int idEmpleado
        { get { return _idEmpleado; } set { _idEmpleado = value; } }

        public string Empleado
        { get { return _Empleado; } set { _Empleado = value; } }

        public string Usuario
        { get { return _Usuario; } set { _Usuario = value; } }

        public string Password
        { get { return _Password; } set { _Password = value; } }

        public DateTime Fecha
        { get { return _Fecha; } set { _Fecha = value; } }
    }
}
