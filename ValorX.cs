using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4do7
{
    public class ValorX
    {
        public int X { get; set; }
        public void valorX()
        {
            Console.WriteLine("valor para X");
            X = int.Parse(Console.ReadLine());

            if (X < 0)
            {
                Console.WriteLine(X);
            }
            else if (X > 0)
            {
                int b = X * (-1);
                Console.WriteLine(b);
            }
        }
    }
}
