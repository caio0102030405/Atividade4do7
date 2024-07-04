using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4do7
{
    public class Estoque
    {
        public int quantidadeMinima { get; set; }
        public int quantidadeMaxima { get; set; }
        public Estoque(int max, int min) 
        {
            quantidadeMaxima= max;
            quantidadeMinima= min;
        }
        public void CalcularEstoque()
        {
            int EstoqueMedio;
            EstoqueMedio = (quantidadeMinima + quantidadeMaxima) / 2;
            Console.WriteLine(EstoqueMedio);
        }
    }
}
