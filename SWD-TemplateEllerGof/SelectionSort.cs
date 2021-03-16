using System;
using System.Collections.Generic;
using System.Text;

namespace SWD_TemplateEllerGof
{
    public class SelectionSort:ISorter
    {
        public void ConcreteSorter(int[] unsortedArray)
        {
            int i;
            int N = unsortedArray.Length;

            for (i = 0; i < N - 1; i++)
            {
                int k = IntArrayMin(unsortedArray, i);
                if (i != k) ;
                //exchange(unsortedArray, i, k);
            }
        }

        public static int IntArrayMin(int[] data, int start)
        {
            int minPos = start;
            for (int pos = start + 1; pos < data.Length; pos++)
                if (data[pos] < data[minPos])
                    minPos = pos;
            return minPos;
        }
    }
}
