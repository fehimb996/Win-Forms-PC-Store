using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsMathClassLibrary;

namespace clsMathConsoleAppDebug
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("unesi broj:");
            int broj = int.Parse(Console.ReadLine());
            long[] l = clsMath.GenFibonacci(broj);
            foreach (long v in l)
            {
                Console.WriteLine(v);
            }
            Console.Read();
        }
    }
}
