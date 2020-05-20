using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugi
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[] { 50, 40, 30, 35, 45, 100, 0, -10, -5, -15 };
            NumberSequence sequence1 = new NumberSequence(array);
            SearchStrategy linear1 = new LinearSearch(100);
            sequence1.SetSearchStrategy(linear1);
            Console.WriteLine("Linear search number (100):");           // primjer kada je zadani broj u nizu i pronađen
            sequence1.Search();

            NumberSequence sequence2 = new NumberSequence(array);
            SearchStrategy linear2 = new LinearSearch(80);
            sequence2.SetSearchStrategy(linear2);
            Console.WriteLine("Linear search number (80):");           // primjer kada zadani broj nije u nizu i ne može ga pronaći
            sequence2.Search();
        }
    }
}
