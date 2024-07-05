using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4do7
{
    public class Valores
    {
        public int ValorA { get; set; }
        public int ValorB { get; set;}

        public void TrocarValor()
        {
            Console.WriteLine("Digite um valor para A");
            ValorA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para B");
            ValorB= int.Parse(Console.ReadLine());

            Console.WriteLine($"A: {ValorA}, B: {ValorB}");
            int troca = 0;
            troca = ValorA;
            ValorA = ValorB;
            ValorB = troca;

            Console.WriteLine($"A: {ValorA}\nB: {ValorB}");
        }
    }
}
