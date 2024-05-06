using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Algorithms
{
    internal class InsertionSort : ISortingAlgorithms
    {
        public readonly int[] _elements;
        public InsertionSort(int[] elements) { 
            _elements = elements;
        }

        public int[] Sort()
        {
            int n = _elements.Length;

            for (int i = 1; i < n; ++i) { 
            
                int key = _elements[i];
                int j = i - 1;

                while (j >= 0 && _elements[j] > key) {
                    _elements[j+1] = _elements[j];
                    j--;
                }

                _elements[j + 1] = key;
            }

            return _elements;
        }
    }
}
