using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Algorithms
{
    internal class HeapSort : ISortingAlgorithms
    {
        private readonly int[] _elements;
        public HeapSort(int[] elements) { 
            _elements = elements;
        }
        public int[] Sort()
        {
            int n = _elements.Length;

            for (int i = n / 2 - 1; i >= 0; i--) {
                Heapify(_elements, n, i);
            }

            for (int i = n - 1; i > 0; i--) { 
                int temp = _elements[0];
                _elements[0] = _elements[i];
                _elements[i] = temp;

                Heapify(_elements, i, 0);
            }

            return _elements;
        }

        private void Heapify(int[] elements, int n, int i) {
            int largest = i;

            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && elements[left] > elements[largest]) {
                largest = left;
            }

            if(right < n && elements[right] > elements[largest]) {
                largest = right;
            }

            if (largest != i) {
                int temp = elements[i];
                elements[i] = elements[largest];   
                elements[largest] = temp;

                Heapify(elements, n, largest);
            }
        }

    }
}
