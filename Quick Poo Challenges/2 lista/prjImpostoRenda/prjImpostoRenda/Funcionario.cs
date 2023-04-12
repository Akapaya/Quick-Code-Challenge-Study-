using System;
using System.Collections.Generic;
using System.Text;

namespace prjImpostoRenda
{
    /// <summary>
    /// Classe Funcionário para Cálculo do IRPF
    /// </summary>
    class Funcionario
    {
        // Data members , campos
        private int _idade;
        private string _nome;
        private double _qtHoras;
        private char _sexo;
        private double _valorHora;

        // Properties
        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public char Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }
        public double QtHoras
        {
            get { return _qtHoras; }
            set { _qtHoras = value; }
        }
        public double ValorHora
        {
            get { return _valorHora; }
            set { _valorHora = value; }
        }
        public double SalarioBruto
        {
            get { return _qtHoras * _valorHora; }
        }
        public double ImpostoRetido
        {
            get
            {
                if (SalarioBruto <= 1257.12)
                    return 0;
                else
                {
                    if (SalarioBruto <= 2512.08)
                        return SalarioBruto * 0.15 - 188.57;
                    else
                        return SalarioBruto * 0.275 - 502.58;
                }
            }
        }
        public double SalarioLiquido
        {
            get { return SalarioBruto - ImpostoRetido; }
        }

        // Methods
        public double ReajustarValorHora(double x)
        {
            ValorHora = ValorHora + (ValorHora * (x/100)) ;
            return ValorHora;
        }

        // Constructors
        public Funcionario()
        {
            _idade = 20;
            _nome = "Gregory Valentim";
            _sexo = 'M';
            _qtHoras = 240;
            if(_valorHora==0.0)
            _valorHora = 15;
        }
        /// <summary>
        /// Parâmetros para o método
        /// </summary>
        /// <param name="i">Idade</param>
        /// <param name="n">Nome</param>
        /// <param name="s">Sexo</param>
        /// <param name="q">Quantidade de Horas</param>
        /// <param name="v">Valor da Hora</param>
        public Funcionario(int i, string n, char s, double q, double v)
        {
    
            _idade = i;
            _nome = n;
            _sexo = s;
            _qtHoras = q;
            _valorHora = v;
        }
    }
}
