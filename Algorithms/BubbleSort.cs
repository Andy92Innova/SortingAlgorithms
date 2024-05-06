using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Algorithms
{
    internal class BubbleSort : ISortingAlgorithms
    {
        private readonly int[] _elements;

        public BubbleSort(int[] elements) { 
            _elements = elements;
        }

        public int[] Sort()
        {
            int n = _elements.Length;

            for (int i = 0; i < n-1; i++) {
                for (int j = 0; j < n - i - 1; j++) {
                    if (_elements[j] > _elements[j + 1]) {
                        int temp = _elements[j+1];
                        _elements[j + 1] = _elements[j];
                        _elements[j] = temp;
                    }
                }
            }

            return _elements;
        }
    }
}
