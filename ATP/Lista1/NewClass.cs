using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista_1
{
    public class NewClass
    {
        public static void Rodar(){
        Console.WriteLine("Questão 3");

        //declaração de variáveis
        double a, b, di, pe, ar;

        //entrada de dados
        Console.WriteLine("Entre com a base");
        b = double.Parse(Console.ReadLine());

        Console.WriteLine("Entre com a altura");
        a = double.Parse(Console.ReadLine());

        //Executar os cálculos
        pe = 2 * (a + b);
        ar = a * b;

        di = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        
        //Saída de dados
        Console.WriteLine("Resultado do perimetro: " + pe);
        Console.WriteLine("Resultado do área é: " + ar);
        Console.WriteLine("Resultado da diagonal é: " + di.ToString("F2"));
    }
    }
}