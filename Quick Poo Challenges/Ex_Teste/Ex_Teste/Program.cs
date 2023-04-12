using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int NF;
            double abono = 0, inss = 0, sali, abonosurpresa=0;
            Random aboale = new Random();

            do
            {
                try
                {
                    Console.WriteLine("Insira o numero de funcionarios");
                    NF = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Insira somente numeros maior que 0 e menor que 156");
                    Console.ReadKey();
                    return;
                }
            } while(NF < 1 || NF > 155);
            
            int ale = aboale.Next(1, NF);
            string[] nome = new string [NF];
            string[] setor= new string [NF];
            int[] sal = new int[NF];
            
            for (int i = 0; i <= NF-1; i++)
            {
                Console.WriteLine("Escreva o nome do funcionario");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Escreva o setor do funcionario, 'O' para operacional / 'A' para administrador");
                setor[i] = Console.ReadLine();
                Console.WriteLine("Insira o salario bruto do funcionario");
                sal[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Matricula\t nome\t setor\t salario\t abono\t abono surptesa\t inss\t salario liquido");
            for (int T = 0; T <= NF-1; T++)
            {
                
                if (sal[T] < 1000 && setor[T] == "A")
                {
                    abono = (sal[T] * 0.1);
                }
                
                if (sal[T] > 5525 && setor[T] == "O")
                {
                    abono = (sal[T] * 0.01);
                }
                
                if (sal[T] <= 1000)
                {
                    inss = sal[T] * 0.1;
                }
                else
                {
                    inss = sal[T] * 0.11;
                }
                if (T == ale)
                {
                    abonosurpresa = sal[T] * 0.35;
                    sali = (sal[T] + abono + abonosurpresa) - inss;
                    Console.WriteLine("{0}\t {1}\t {2}\t {3}\t {4}\t {5}\t {6}\t {7}", T, nome[T], setor[T], sal[T], abono, abonosurpresa, inss, sali);
                }
                else
                {
                    sali = (sal[T] + abono) - inss;
                    Console.WriteLine("{0}\t {1}\t {2}\t {3}\t {4}\t {5}\t {6}\t {7}", T, nome[T], setor[T], sal[T], abono, 0, inss, sali);
                }

                abonosurpresa = 0;
                abono = 0;
                inss = 0;
            }
            
            Console.ReadKey();
        }
    }
}
