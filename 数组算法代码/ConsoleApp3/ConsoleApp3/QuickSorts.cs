using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    //快速排序
     class QuickSorts
    {
        public static void Main(string[] args)
        {
            int[] array = { 11, 2, 78, 23, 5, 8, 55, 33, 88, 22, 1, 14, 15 };
            QuickSorts Quick = new QuickSorts();
            Quick.QuickSort(array, 0, array.Length - 1);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ",");
            }
            Console.ReadLine();
        }
        void QuickSort(int[] array, int low, int hight)
        {
            int loc;
            if (low < hight)
            {
                loc = Partition(array, low, hight);

                QuickSort(array, low, loc - 1);
                QuickSort(array, loc + 1, hight);



            }
        }
        static int Partition(int[] array, int low, int high)
        {
            int pivot = array[low];
            while (low < high)
            {
                while (low < high && array[high] > pivot)
                {
                    high--;
                }


                array[low] = array[high];
                while (low < high && array[low] < pivot)
                {
                    low++;
                }
                array[high] = array[low];
            }
            array[low] = pivot;
            return low;
        }
    }

}
