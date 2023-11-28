using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Empleados
    {
        private int _idEmpleado;
        private string _Nombre;
        private string _Genero;
        private string _Foto;
        private string _Puesto;
        private Boolean _Activo;
        private DateTime _FechaNacimiento;
        private DateTime _FechaRegistro;

        public int idEmpleado
        { get { return _idEmpleado; } set { _idEmpleado = value; } }

        public string Nombre
        { get { return _Nombre; } set { _Nombre = value; } }

        public string Genero
        { get { return _Genero; } set { _Genero = value; } }

        public string Foto
        { get { return _Foto; } set { _Foto = value; } }

        public DateTime FechaNacimiento
        { get { return _FechaNacimiento; } set { _FechaNacimiento = value; } }

        public string Puesto
        { get { return _Puesto; } set { _Puesto = value; } }

        public Boolean Activo
        { get { return _Activo; } set { _Activo = value; } }

        public DateTime FechaRegistro
        { get { return _FechaRegistro; } set { _FechaRegistro = value; } }
    }
}
