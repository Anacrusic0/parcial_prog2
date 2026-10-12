using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace Parcial
{
    public class Inscripion
    {

        private Actividad _actividad;
        public Actividad ActividadRegister
        {
            get { return _actividad; }
            set { _actividad = value; }
        }
        private string _socioDNI;
        public string SocioDNI
        {
            get { return _socioDNI; }
            set { _socioDNI = value; }
        }
        private int _cantSesiones;
        public int CantSesiones
        {
            get { return _cantSesiones; }
            set { _cantSesiones = value; }
        }
        private double _costoBase;
        public double CostoBase
        {
            get { return _costoBase; }
            set { _costoBase = value; }
        }
        public Inscripion(string dni, Actividad actividad, int canSesiones)
        {
            _costoBase = 3000;
            _socioDNI = dni;
            _actividad = actividad;
            _cantSesiones = canSesiones;
        }

        public int GetSesiones()
        {
            return CantSesiones;
        }

        public void CostoTotal(Actividad actividad, int cantSesiones)
        {
            double CostoTotal = actividad.CuotaBase + CostoBase;
            System.Console.WriteLine($"el costo de la actividad elegida es: {actividad.CuotaBase}");
            System.Console.WriteLine($"por lo que el costo total de su inscripcion es de {CostoTotal}");
        }
    }
}