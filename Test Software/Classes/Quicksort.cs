using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_Software.Classes
{
    public class Quciksort
    {
        public static void QuickSort(int[] a)
        {
            QuickSort(a, 0, a.Length - 1);
        }


        public static void QuickSort(int[] A, int left, int right)
        {
            if (left > right || left < 0 || right < 0) return;

            int index = partition(A, left, right);

            if (index != -1)
            {
                QuickSort(A, left, index - 1);
                QuickSort(A, index + 1, right);
            }
        }

        private static int partition(int[] A, int left, int right)
        {
            if (left > right) return -1;

            int end = left;

            int pivot = A[right];    // choose last one to pivot, easy to code
            for (int i = left; i < right; i++)
            {
                if (A[i] < pivot)
                {
                    swap(A, i, end);
                    end++;
                }
            }

            swap(A, end, right);

            return end;
        }

        private static void swap(int[] A, int left, int right)
        {
            int tmp = A[left];
            A[left] = A[right];
            A[right] = tmp;
        }

    }
}