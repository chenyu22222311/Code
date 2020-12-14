using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    //插入排序
    class InsertionSorts
    {
        public static void Main(string[] args)
        {
            int[] array = { 11, 2, 78, 23, 5, 8, 55, 33, 88, 22, 1, 14, 15 };
            InsertionSort(array);
            foreach (int arr in array)
            {
                Console.WriteLine(arr);
            }
            Console.ReadLine();
        }
        static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i;j > 0&&array[j]<array[j-1];j--)
                {
                    int temp = array[j];
                    array[j] = array[j - 1];
                    array[j-1] = temp;


                }

            }
        }
    }
}
