using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Sort
{
    public class MergeSort
    {
        public static void Execute()
        {
            MergeSort sort = new MergeSort();
            int[] numArr = new int[6] { 3, 7, 1, 2, 8, 10 };

            sort.DoMergeSort(numArr);
            sort.DisplayArray(numArr);

        }

        public void DoMergeSort(int[] arr)
        {
            DoMergeSort(arr, 0, arr.Length - 1);
        }
        public void DoMergeSort(int[] arr, int start, int end)
        {
            if (end <= start)
            {
                return; // We are done tranversing array
            }

            int mid = (start + end) / 2;
            DoMergeSort(arr, start, mid);
            DoMergeSort(arr, mid + 1, end);
            DoMerge(arr, start, mid, end);
        }

        public void DoMerge(int[] inputArray, int start, int mid, int end)
        {
            int[] tempArray = new int[end - start + 1];

            int leftSlot = start;
            int rightSlot = mid + 1;
            int k = 0;

            while (leftSlot <= mid && rightSlot <= end)
            {
                if (inputArray[leftSlot] < inputArray[rightSlot])
                {
                    tempArray[k] = inputArray[leftSlot];
                    leftSlot++;
                }
                else
                {
                    tempArray[k] = inputArray[rightSlot];
                    rightSlot++;
                }
                k++;
            }

            if (leftSlot <= mid)
            {
                while (leftSlot <= mid)
                {
                    tempArray[k] = inputArray[leftSlot];
                    leftSlot++;
                    k++;
                }
            }
            else if (rightSlot <= end)
            {
                while (rightSlot <= end)
                {
                    tempArray[k] = inputArray[rightSlot];
                    rightSlot++;
                    k++;
                }
            }

            for (int i = 0; i < tempArray.Length; i++)
            {
                inputArray[start + i] = tempArray[i];
            }
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
