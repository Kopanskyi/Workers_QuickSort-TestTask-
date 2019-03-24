using System;
using System.Collections.Generic;
using System.Text;

namespace Workers_TestTask
{
    static class Sort
    {
        public static void Quick_Sort(IList<Worker> list, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(list, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(list, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(list, pivot + 1, right);
                }
            }
        }

        private static int Partition(IList<Worker> list, int left, int right)
        {
            Worker pivot = list[left];
            while (true)
            {
                while (list[left].CompareTo(pivot) > 0)
                {
                    left++;
                }

                while (list[right].CompareTo(pivot) < 0)
                {
                    right--;
                }

                if (left < right)
                {
                    if (list[left].CompareTo(list[right]) == 0)
                        return right;

                    Worker temp = list[left];
                    list[left] = list[right];
                    list[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
