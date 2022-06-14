using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int total;
            int x = 0;
            int y = 1;
            Boolean existe = false;

            Console.WriteLine("Informe um n�mero");
            int num = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            while (x <= num)
            {
                total = x + y;
                y = x;
                x = total;

                if (num == total || num == 0 )
                {
                    Console.WriteLine("O n�mero existe na sequencia fibonacci!");
                    existe = true;
                    x = num + 1;

                }

            }

            if (existe == false)
            {
                Console.WriteLine("O n�mero n�o existe na sequencia fibonacci!");

            }

            Console.ReadKey();

        }
    }
}
