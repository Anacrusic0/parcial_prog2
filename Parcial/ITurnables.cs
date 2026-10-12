using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial
{
    public interface ITurnables
    {
        public int CupoMax { get; }
        public int TurnosSacados { get; set; }
        public string DescripcionHorario { get; }
        
        public HashSet<Socio> turnados { get; }
    }

}