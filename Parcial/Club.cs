using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Parcial
{
    public class Club
    {
        public List<Inscripion> _inscripions;

        public Dictionary<string, Socio> _socios;

        public List<Actividad> _actividads;

        public Club(List<Inscripion> inscripions, Dictionary<string,Socio> socios, List<Actividad> actividads)
        {
            _inscripions = inscripions;
            _actividads = actividads;
            _socios = socios;
        }

        public void RegistrarInscripciones(string dni, Actividad actividad, int cantSesiones)
        {
            _inscripions.Add(new Inscripion(dni,actividad,cantSesiones));
        }

        public void ReservarTurno(Socio socio, ITurnables turnable)
        {
            if (turnable.CupoMax > 0)
            {
                System.Console.WriteLine($"el socio con DNI {socio.Dni} tiene turno para asistir de {turnable.DescripcionHorario}");
                turnable.CupoMax--;
            }
            else
            {
                System.Console.WriteLine("no quedan turnos para la actividad seleccionada");
            }
        }
    }
}