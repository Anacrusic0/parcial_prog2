using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial
{
    public class Socio
    {
        private string _dni;
        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public Socio(string dni)
        {
            _dni = dni;
        }
        public void Inscribirse(Club club, Actividad actividad,int cantSesiones)
        {
            club.RegistrarInscripciones(Dni, actividad, cantSesiones);
        }
    }
}