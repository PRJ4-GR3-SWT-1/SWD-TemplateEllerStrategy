using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SWD_TemplateEllerGof
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] kurt = ArrayGenerator(1000, 33, 10);
            int[] kurt2 = kurt;
            //kurt.ToList().ForEach(i => Console.WriteLine(i.ToString()));

            Console.WriteLine("Nu sorterer vi:");
            ISorter bs = new BubbleSort();
            
            SuperSorter ss= new SuperSorter(bs);
            ss.SortArray(kurt);
            //kurt.ToList().ForEach(i => Console.WriteLine(i.ToString()));

            //int[] kurt2 = ArrayGenerator(1000, 33, 10);
            ISorter sel = new SelectionSort();
            ss.sorter = sel;
            ss.SortArray(kurt2);
        }

       public static int[] ArrayGenerator(int length, int max, int seed)
       {
           int[] array = new int[length];

           Random rnd = new Random(seed);

           for (int i = 0; i < length; i++)
           {
                   array[i]=  rnd.Next(0, max);
           }

            return array;
       }
    }
}
