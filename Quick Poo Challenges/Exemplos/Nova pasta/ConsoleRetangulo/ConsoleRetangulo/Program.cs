using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
             //Retangulo r = new Retangulo(2,7);
             Retangulo2 r = new Retangulo2();
            // Retangulo r = new Retangulo(3);
             if (r.quadrado())
                 Console.WriteLine("É");
             else
                 Console.WriteLine("NÃO");

            Console.WriteLine("A altura é {0}", r.altura);
            Console.WriteLine("A base é {0}", r.largura);
            Console.WriteLine("A área é {0}", r.area);
            Console.WriteLine("O Perímetro é {0}", r.perimetro);

            Console.ReadKey();
        }
    }
}
