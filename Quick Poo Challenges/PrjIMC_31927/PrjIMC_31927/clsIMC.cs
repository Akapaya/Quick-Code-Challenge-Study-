using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjIMC_31927
{
    class clsIMC
    {
        private double _peso;
        private double _altura;

        public double altura
        {
            set
            {
                _altura = value;
            }
            get
            {
                return _altura;
            }
        }
        public double peso
        {
            set
            {
                _peso = value;
            }
            get
            {
                return _peso;
            }
        }

        public string imcS(double alt, double pes)
        {
            return (_peso / Math.Pow(_altura, 2)).ToString();
        }
    }
}
