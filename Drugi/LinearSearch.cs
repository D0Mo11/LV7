using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugi
{
    class LinearSearch : SearchStrategy
    {
        private double x;
        public LinearSearch(double x)
        {
            this.x = x;
        }

        public override void Search(double[] array)
        {
            int n = array.Length;
            int f = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] == x)
                {
                    f = 1;
                }
            }
            if (f == 1)
            {
                Console.WriteLine("Broj je pronadjen");
            }
            else
            {
                Console.WriteLine("Broj nije pronadjen");

            }

        }
    }
}
