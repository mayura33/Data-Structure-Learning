using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Sort
{
    public class Sorting
    {

        public static void Execute()
        {
            Sorting sort = new Sorting();
            int[] numArr = new int[6] { 3, 7, 1, 2, 8, 10 };
            sort.DisplayArray(numArr);

        }

        public int[] DoSelectionSort(int[] numArr)
        {
            for (int i = 0; i < numArr.Length; i++)
            {
                int currentMinimum = i;
                for (int j = i + 1; j < numArr.Length; j++)
                {
                    if (numArr[j] < numArr[currentMinimum])
                    {
                        currentMinimum = j;
                    }
                }
                int temp = numArr[i];
                numArr[i] = numArr[currentMinimum];
                numArr[currentMinimum] = temp;
            }
            return numArr;
        }

        public int[] DoInsertionSort(int[] numArr)
        {
            for (int i = 0; i < numArr.Length - 1; i++)
            {
                int element = numArr[i];
                int j = i - 1;

                while (j >= 0 && numArr[j] > element)
                {
                    numArr[j + 1] = numArr[j];
                    j--;
                }

                numArr[j + 1] = element;
            }
            return numArr;
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
