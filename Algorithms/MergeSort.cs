using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Algorithms
{
    internal class MergeSort : ISortingAlgorithms
    {
        private readonly int[] _elements;
        public MergeSort(int[] elements)
        {
            _elements = elements;
        }

        public int[] Sort()
        {
            Sort(_elements, 0, _elements.Length - 1);

            return _elements;
        }


        private void Sort(int[] elements, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                Sort(elements, left, middle);
                Sort(elements, middle + 1, right);

                Merge(elements, left, middle, right);
            }
        }

        private void Merge(int[] elements, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int i = 0; i < n1; ++i) {
                L[i] = elements[left + i];
            }

            for (int i = 0; i < n2; ++i) {
                R[i] = elements[middle + 1 + i];
            }

            int x = 0, y = 0;
            int k = left;

            while (x < n1 && y < n2) {
                if (L[x] <= R[y])
                {
                    elements[k] = L[x];
                    x++;
                }
                else {
                    elements[k] = R[y];
                    y++;
                }
                k++;
            }

            while (x < n1) {
                elements[k] = L[x];
                x++;
                k++;
            }

            while (y < n2) {
                elements[k] = R[y];
                y++;
                k++;
            }


        }

    }
}
