using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SWD_TemplateEllerGof
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] kurt = ArrayGenerator(10, 33, 10);
            
            kurt.ToList().ForEach(i => Console.WriteLine(i.ToString()));

            Console.WriteLine("Nu sorterer vi:");
            ISorter bs = new BubbleSort();
            SuperSorter ss= new SuperSorter(bs);
            ss.SortArray(kurt);
            kurt.ToList().ForEach(i => Console.WriteLine(i.ToString()));
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
