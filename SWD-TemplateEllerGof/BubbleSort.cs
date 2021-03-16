using System;
using System.Collections.Generic;
using System.Text;

namespace SWD_TemplateEllerGof
{
    public class BubbleSort: ISorter
    {
        public void ConcreteSorter(int[] unsortedArray)
        {
            int t;
            for (int p = 0; p <= unsortedArray.Length - 2; p++)
            {
                for (int i = 0; i <= unsortedArray.Length - 2; i++)
                {
                    if (unsortedArray[i] > unsortedArray[i + 1])
                    {
                        t = unsortedArray[i + 1];
                        unsortedArray[i + 1] = unsortedArray[i];
                        unsortedArray[i] = t;
                    }
                }
            }

            return unsortedArray;
        }
    }
}
