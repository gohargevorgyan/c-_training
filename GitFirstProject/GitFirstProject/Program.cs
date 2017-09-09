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
            Console.WriteLine("Enter your array length");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your array element");
            string temp = Console.ReadLine();
            int[] array = new int[length];

            string[] numberStrings = temp.Split(' ');
            for (int i = 0; i < numberStrings.Length; i++)
            {
                if (string.IsNullOrEmpty(numberStrings[i]) != true)
                {
                    array[i] = int.Parse(numberStrings[i]);
                }
            }
            Console.WriteLine(" This is your  sorted array!");
            SortingAlgorithms.InsertionSort(array);
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
              Console.Write("{0},", array[i]);
            }
            Console.Write("]");
            Console.ReadLine();
        }
    }
}
