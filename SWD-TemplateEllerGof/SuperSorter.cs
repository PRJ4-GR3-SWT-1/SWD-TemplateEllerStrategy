using System;
using System.Diagnostics;

namespace SWD_TemplateEllerGof
{
    public interface ISorter
    {
        public void ConcreteSorter(int[] unsortedArray);
    }


    public class SuperSorter
    {
        public ISorter sorter;

        public SuperSorter(ISorter sorter)
        {
            this.sorter = sorter;
        }


        public void SortArray(int[] array)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            sorter.ConcreteSorter(array);
            stopwatch.Stop();
            Console.WriteLine(sorter.ToString()+ ". Det tog kun "+ stopwatch.ElapsedMilliseconds + "ms.");
        }

        public static void Swap(int[] array, int a, int b)
        {
            int temporary;

            temporary = array[a];
            array[a] = array[b];
            array[b] = temporary;
        }
    }
}