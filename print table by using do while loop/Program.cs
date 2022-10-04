using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_table_by_using_do_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, M;
            Console.WriteLine("enter any number");
            N=Convert.ToInt32(Console.ReadLine());
             M = 1;
            do
            {
                Console.WriteLine("{0}*{1}={2}", N, M, (N * M));
                M++;
            } while (M <= 10);
        }
    }
}
