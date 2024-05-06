using SortingAlgorithms.Algorithms;

namespace SortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ISortingAlgorithms[] algorithms = {
                new BubbleSort(new int[] { 2,4,3,5,1 } ),
                new InsertionSort(new int[] { 4,2,5,1,3 } ),
                new SelectionSort(new int[] { 4,2,3,5,1 } ),
                new MergeSort(new int[] { 4,2,4,5,1 } ),
                new QuickSort(new int[] { 4,2,1,1,3 } ),
                new HeapSort(new int[] { 4,2,2,1,3 } )
            };

            foreach( ISortingAlgorithms alg in algorithms )
            {
                Console.WriteLine($"{alg.ToString().Split('.')[2]}: { string.Join(',', alg.Sort()) }");
            }


            Console.ReadLine();
        }
    }
}