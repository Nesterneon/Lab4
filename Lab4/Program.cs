using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение N");
            int N= Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= (2 * N - 1); i += 2)
            {
                sum += i;
                Console.WriteLine(sum);

            }
            Console.Write("для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
