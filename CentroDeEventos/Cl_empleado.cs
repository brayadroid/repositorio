using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentroDeEventos
{
    public class Cl_empleado
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private SEXO _sexo;

        public SEXO Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }
        private int _edad;

        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }
        private int _fechanacimiento;

        public int Fechanacimiento
        {
            get { return _fechanacimiento; }
            set { _fechanacimiento = value; }
        }
        private string _labor;

        public string Labor
        {
            get { return _labor; }
            set { _labor = value; }
        }
        private string _horarioDisponible;

        public string HorarioDisponible
        {
            get { return _horarioDisponible; }
            set { _horarioDisponible = value; }
        }
    }
}
