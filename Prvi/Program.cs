using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvi
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[] { 50, 40, 30, 35, 45, 100, 0, -10, -5, -15 };
            NumberSequence sequence1 = new NumberSequence(array);
            SortStrategy bubble = new BubbleSort();
            Console.WriteLine("Niz prije sortiranja:\n" + sequence1.ToString());
            sequence1.SetSortStrategy(bubble);
            sequence1.Sort();
            Console.WriteLine("Bubble sort:\n" + sequence1.ToString());

            NumberSequence sequence2 = new NumberSequence(array);
            SortStrategy sequential = new SequentialSort();
            Console.WriteLine("Niz prije sortiranja:\n" + sequence2.ToString());
            sequence2.SetSortStrategy(sequential);
            sequence2.Sort();
            Console.WriteLine("Sequential sort:\n" + sequence2.ToString());

            NumberSequence sequence3 = new NumberSequence(array);
            SortStrategy comb = new CombSort();
            Console.WriteLine("Niz prije sortiranja:\n" + sequence3.ToString());
            sequence3.SetSortStrategy(comb);
            sequence3.Sort();
            Console.WriteLine("Comb sort:\n" + sequence3.ToString());
        }
    }
}
