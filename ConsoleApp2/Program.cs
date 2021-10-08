using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static int math(int ch1, int zn1, int ch2, int zn2, out int ch1zn2, out int ch2zn1)
        {
            ch1zn2 = ch1 * zn2;
            ch2zn1 = ch2 * zn1;
            return zn1 * zn2;
        }

        static void count_2(int x, ref int count)
        {
            while (x%2==0)
            {
                x /= 2;
                count++;
            }
        }

        static void Main(string[] args)
        {
            int ch1, ch2;
            int oz = math(2, 3, 4, 5, out ch1, out ch2);

            int count = 0;
            count_2(32, ref count);
            count_2(128, ref count);
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
