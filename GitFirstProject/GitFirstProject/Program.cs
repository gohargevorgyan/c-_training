using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter your array length!");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your array element");
            int[] array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            ///////////////////////insertion sort

            InsertionSort(array);
            Console.WriteLine("Sorted Array");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0}", array[i]);
            }

            Console.ReadLine();
        }
            
        public static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
    }

}
