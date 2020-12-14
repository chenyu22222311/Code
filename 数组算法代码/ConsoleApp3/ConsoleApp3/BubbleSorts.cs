using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    //冒泡排序
    class BubbleSorts
    {
        public static void Main(string[] args)
        {
            int[] array = { 11, 2, 78, 23, 5, 8, 55, 33, 88, 22, 1, 14, 15 };
            BubbleSort(array);
            foreach (int arr in array)
            {
                Console.WriteLine(arr);
            }
            Console.ReadLine();
        }

        static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j =0; j < array.Length-1-i; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        int temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }
                }
            }

        }
    }
}

