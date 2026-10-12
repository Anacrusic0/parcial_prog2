using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial
{
    public class Natacion : Actividad, ITurnables
    {
        public static double costo = 6000, costoExceso = 1500, sesionesIncluidas = 4;

        
        public HashSet<Socio> turnados { get; }

        private int _cupoMax;
        public int CupoMax
        {
            get { return _cupoMax; }
        } 
        
        public int TurnosSacados { get; set; }
        

        private string _descripcionHorario;
        public string DescripcionHorario
        {
            get { return _descripcionHorario; }
        }

        public override double CalcularCostoMensual(Actividad actividad, int cantSesiones)
        {
            double costoMensual;
            if(cantSesiones > sesionesIncluidas)
            {
                costoMensual = actividad.CuotaBase + costo + (costoExceso * cantSesiones);
                return costoMensual;
            }
            else
            {
                return costoMensual = costo + actividad.CuotaBase;
            }
        }
        

        
        public Natacion(string nombre, int codigo, double cuotaBase, HashSet<Socio> turnados) : base(nombre,codigo,cuotaBase)
        {
            _cupoMax = 30;
            _descripcionHorario = "8:30hs-9:30hs";
            this.turnados = turnados;
        }
        

    }
}