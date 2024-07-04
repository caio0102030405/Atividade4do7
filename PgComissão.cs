using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4do7
{
    public class pgComissão
    {
        public int IdentificarVendedor { get; set; }
        public int CódigoPeça { get; set; }
        public double PreçoPeça { get; set; }
        public int QtdVendida { get; set; }
        public double TotalVenda { get; set; }  
        public double Comissão { get; set; }


        public pgComissão(int identificarVendedor, int códigoPeça, double preçoPeça, int qtdVendida)
        {
            IdentificarVendedor = identificarVendedor;
            CódigoPeça = códigoPeça;
            PreçoPeça = preçoPeça;
            QtdVendida = qtdVendida;
        }

        public void PagamentoDeComissão()
        {
            Console.WriteLine("Qual o valor da peça?");
            PreçoPeça = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantas peças foram vendidas?");
            QtdVendida = int.Parse(Console.ReadLine());

            TotalVenda = CódigoPeça + QtdVendida;
            Comissão = (TotalVenda) * 0.5;

            Console.WriteLine($"A comissão é {Comissão}%");
        }
    }
}
