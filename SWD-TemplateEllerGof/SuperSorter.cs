namespace SWD_TemplateEllerGof
{
    public interface ISorter
    {
        public int[] ConcreteSorter(int[] unsortedArray);
    }
    public class SuperSorter
    {
        public ISorter sorter;

        public int[] SortArray(int[] array)
        {
            int[] sortedArray= sorter.ConcreteSorter(array);
            return sortedArray;
        }
    }
}