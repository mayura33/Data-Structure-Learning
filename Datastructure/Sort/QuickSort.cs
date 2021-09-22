using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Sort
{
    public class QuickSort
    {
        public static void Execute()
        {
            QuickSort sort = new QuickSort();
            int[] numArr = new int[6] { 3, 7, 1, 2, 8, 10 };

            sort.DoQuickSort(numArr);
            sort.DisplayArray(numArr);

        }
        public void DoQuickSort(int[] arr)
        {
            DoQuickSort(arr, 0, arr.Length - 1);
        }
        public void DoQuickSort(int[] inputArray, int start, int end)
        {
            if (start < end)
            {
                int partition = Partition(inputArray, start, end);
                DoQuickSort(inputArray, start, partition - 1);
                DoQuickSort(inputArray, partition + 1, end);
            }
        }

        public int Partition(int[] inputArray, int lb, int ub)
        {
            int pivot = inputArray[lb];

            int start = lb;
            int end = ub;

            while (start < end)
            {
                while (inputArray[start] <= pivot)
                {
                    start++;
                }
                while (inputArray[end] > pivot)
                {
                    end--;
                }

                if (start < end)
                {
                    //SWAP a[start] and a[end]
                    int temp1 = inputArray[start];
                    inputArray[start] = inputArray[end];
                    inputArray[end] = temp1;
                }
            }

            //SWAP LB WITH END
            int temp = inputArray[lb];
            inputArray[lb] = inputArray[end];
            inputArray[end] = temp;

            return end;
        }

        public void DisplayArray(int[] arr)
        {
            Console.Write(" [ ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.Write(" ] ");
        }
    }
}
