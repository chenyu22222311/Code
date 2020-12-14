using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    //选择排序
    class SelectSorts
    {
        public static void Main(string[] args)
        {
            int[] array = { 11, 2, 78, 23, 5, 8, 55, 33, 88, 22, 1, 14, 15 };
            SelectSort(array);
            foreach (int arr in array)
            {
                Console.WriteLine(arr);
            }
            Console.ReadLine();
        }
        static void SelectSort(int[] array)
        {
            for (int i=0;i<array.Length-1;i++)
            {
                int min=i;
                for (int j=i+1;j<array.Length;j++)
                {
                    if (array[j]<array[min])
                    {
                         min= j;
                    }
                }
                int temp=array[min];
                array[min]= array[i];
                array[i]=temp;
            }
        }
    }
}
