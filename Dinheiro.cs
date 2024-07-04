using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4do7
{
    public class Dólar
    {
        public double cotacaoDolar { get; set; }
        public double valor { get; set; }
        public double valorConvertido { get; set; }
        public Dólar()
        {

        }
        public void Conversor()
        {
            Console.WriteLine("Qual é a cotação do Dólar");
            cotacaoDolar = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o seu saldo para conversão");
            valor = double.Parse(Console.ReadLine());

            valorConvertido = cotacaoDolar * valor;
            Console.WriteLine($"O valor convertido: {valorConvertido}");
        }
    }
}
