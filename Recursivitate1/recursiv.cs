using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursivitate1
{
    public static class recursiv
    {
        public static void ParcurgereVector(int[]vector, int n)
        {
            if (n == 1)
                Console.WriteLine(vector[n - 1]);
            else
            {
                ParcurgereVector(vector, n - 1);
                Console.WriteLine(vector[n - 1]);
            }
        }
    }
}
