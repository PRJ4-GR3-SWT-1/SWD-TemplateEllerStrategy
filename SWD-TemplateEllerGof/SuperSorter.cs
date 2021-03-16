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


        public int[] SortArray(int[] array)
        {
            int[] sortedArray= sorter.ConcreteSorter(array);
            return sortedArray;
        }
    }
}