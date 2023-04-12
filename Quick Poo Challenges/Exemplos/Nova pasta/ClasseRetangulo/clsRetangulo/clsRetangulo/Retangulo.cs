using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clsRetangulo
{
    public class Retangulo
    {

        // Data members ou fields
        private int _largura;
        private int _altura;

        // Properties
        public int largura
        {
            set { _largura = value; }
            get { return _largura; }
        }
        public int altura
        {
            set { _altura = value; }
            get { return _altura; }
        }
        public int area
        {
            get { return _largura * _altura; }
        }
        public int perimetro
        {
            get { return 2 * (_largura + altura); }
        }

        // Methods
        public void adicionarAltura(int x)
        {
            _altura = _altura + x;
        }
        public bool quadrado()
        {
            if (_altura == _largura)
                return true;
            else
                return false;
        }

        // Constructors
        public Retangulo()
        {
            _largura = 3;
            _altura = 4;
        }
        public Retangulo(int x, int y)
        {
            _largura = x;
            _altura = y;
        }
        public Retangulo(int x)
        {
            _altura = _largura = x;
        }
    }
}
