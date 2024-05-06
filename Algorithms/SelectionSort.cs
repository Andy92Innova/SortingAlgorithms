using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Algorithms
{
    internal class SelectionSort : ISortingAlgorithms
    {
        private readonly int[] _elements;
        public SelectionSort(int[] elements) { 
            _elements = elements;
        }

        public int[] Sort()
        {
            int n = _elements.Length;

            for (int i = 0; i < n - 1; i++) {
                int minIndex = i;

                for (int j = i + 1; j < n; j++) {
                    if (_elements[j] < _elements[minIndex]) { 
                        minIndex = j;
                    }
                }

                int temp = _elements[minIndex];
                _elements[minIndex] = _elements[i];
                _elements[i] = temp;

            }

            return _elements;
        }
    }
}
