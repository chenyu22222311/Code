using System;

namespace ConsoleApp3
{
     class ShellSorts
    {

        public static void Main(string[] args)
        {
            int[] array = { 11, 2, 78, 23,88, 22, 1, 14, 15,46,90};
            ShellSort(array);
            foreach (int arr in array)
            {
                Console.WriteLine(arr);
            }
            Console.ReadLine();
        }
        static void ShellSort(int[] array)
        {
            for (int gap=array.Length/2; gap>=1; gap/=2)
            {
                for (int i=gap;i<array.Length;i++)
                {
                    while (i-gap>=0&&array[i]<array[i-gap])
                    {
                        int temp = array[i];
                        array[i] = array[i - gap];
                        array[i - gap] = temp;
                        i = i - gap;

                    }
                }
            }
        }
    }
}
