using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsMathClassLibrary
{
    public class clsMath
    {
        public static long[] GenFibonacci(int brojClanova)
        {
            long[] niz = new long[brojClanova + 1];
            niz[0] = 0;
            niz[1] = 1;
            for (int i = 2; i < brojClanova + 1; i++)
            {
                niz[i] = niz[i - 2] + niz[i - 1];
            }
            return niz;
        }
    }
}
