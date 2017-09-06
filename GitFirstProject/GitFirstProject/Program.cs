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

            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1]= array[j] ;
                    j--;
                }
                array[j + 1] = key;
            }

            Console.WriteLine("Sorted Array");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0}", array[i]);
            }

            Console.ReadLine();
        }
    }
}
