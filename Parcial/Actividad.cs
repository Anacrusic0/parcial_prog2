using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial
{
    public abstract class Actividad
    {
        protected string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        protected int _codigo;
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        protected double _cuotaBase;
        public double CuotaBase
        {
            get { return _cuotaBase; }
            set { _cuotaBase = value; }
        }
        public Actividad(string name, int codigo, double cuotaBase)
        {
            _nombre = name;
            _codigo = codigo;
            _cuotaBase = cuotaBase;
        }

        public abstract double CalcularCostoMensual(Actividad actividad, int cantSesiones);
    }
}