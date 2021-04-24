using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama
{

    class Program
    {
        static sbyte j = 100;
        static sbyte i = 1;
        static sbyte topla()
        {
            sbyte i = 2;
            return i;
        }
        static void Main(string[] args)
        {
            sbyte i = 3;
            sbyte a = topla();
            Console.WriteLine("i değeri:" + i);
            Console.WriteLine("i değeri:" + Program.i);
            Console.WriteLine("i değeri:" + a);
            Console.WriteLine("j değeri:" + j);
            Console.ReadKey();
        }
    }
}
