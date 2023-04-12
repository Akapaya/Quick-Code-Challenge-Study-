using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMC
{
    public class Class1
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
        public double imc
        {
            get
            {
                return_peso / Math.Pow(_altura, 2);
            }
        }

        public string imcS(double alt, double pes)
        {
            return (_peso / Math.Pow(_altura, 2)).ToString();
        }
    }
}
