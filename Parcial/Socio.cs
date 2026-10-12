using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial
{
    public class Socio
    {
        public override bool Equals(object? obj) => 
            obj is Socio otro && StringComparer.Ordinal.Equals(Dni, otro.Dni);
        public override int GetHashCode() => 
            StringComparer.Ordinal.GetHashCode(Dni);
        
        private string _dni;
        public string Dni
        {
            get { return _dni; }
        }

        public Socio(string dni)
        {
            _dni = dni;
        }
        public void Inscribirse(Club club, Actividad actividad,int cantSesiones)
        {
            club.RegistrarInscripciones(this, actividad, cantSesiones);
        }

        public void ReservarTurno(Club club, ITurnables turnables)
        {
            club.RegistrarTurno(this, turnables);
            turnables.turnados.Add(this);
        }
    }
}