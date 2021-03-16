namespace SWD_TemplateEllerGof
{
    interface ISorter
    {
        public void ConcreteSorter();
    }
    public class SuperSorter
    {
        public ISorter sorter;

        public int[] SortArray(int[] array)
        {

        }
    }
}