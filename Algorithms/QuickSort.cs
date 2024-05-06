using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Algorithms
{
    internal class QuickSort : ISortingAlgorithms
    {
        private readonly int[] _elements;
        public QuickSort(int[] elements) {
            _elements = elements;
        }
        public int[] Sort()
        {
            Sort(_elements, 0, _elements.Length - 1);
            return _elements;
        }

        private void Sort(int[] elements, int low, int high) {
            if (low < high) {
                int pi = Partition(elements, low, high);

                Sort(elements, low, pi - 1);
                Sort(elements, pi + 1, high);
            }
        }

        private int Partition(int[] elements, int low, int high) {
            int pivot = elements[high];
            int i = low - 1;

            for (int j = low; j < high; j++) {
                if (elements[j] < pivot) {
                    i++;

                    int temp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = temp;
                }
            }

            int temp1 = elements[i + 1];
            elements[i + 1] = elements[high];
            elements[high] = temp1;

            return i + 1;
        }

    }
}
