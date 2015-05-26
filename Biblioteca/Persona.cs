using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca
{
    abstract class Persona
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private int edad;

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


    }
}
