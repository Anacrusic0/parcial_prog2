using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial
{
    public class Natacion : Actividad, ITurnables
    {
        public static int costo = 6000, CostoXSesion = 1500;
        private int _cupoMax;
        public int CupoMax
        {
            get { return _cupoMax; }
            set { _cupoMax = value; }
        }
        
        private string _descripcionHorario;
        public string DescripcionHorario
        {
            get { return _descripcionHorario; }
            set { _descripcionHorario = value; }
        }
        

        public Natacion(string nombre, int codigo, double cuotaBase) : base(nombre,codigo,cuotaBase)
        {
            _cupoMax = 30;
            _descripcionHorario = "8:30hs-9:30hs";
        }
        
    }
}