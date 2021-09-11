using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Search
{
    public class SimpleSearch
    {
        public static void Execute()
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            SimpleSearch search = new SimpleSearch();
            Console.WriteLine(search.RecursiveSearch(arr, 0, 5));
        }

        public int BinarySearch(int[] arr, int key)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start <= end)
            {
                int q = (start + end) / 2;
                if (key < arr[q])
                {
                    end = end - q;
                }
                else if (key > arr[q])
                {
                    start = start + end;
                }
                else
                {
                    return q;
                }
            }
            return -1;
        }

        public int RecursiveSearch(int[] a, int i, int x)
        {
            if (i > a.Length - 1)
            {
                return -1;
            }
            else if (a[i] == x)
            {
                return i;
            }
            else
            {
                Console.WriteLine("Index at : " + i);
                return RecursiveSearch(a, i + 1, x);
            }
        }
    }
}
