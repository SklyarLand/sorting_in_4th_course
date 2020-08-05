using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algoritmen;

namespace ConsoleApp1
{
    public class Program
    {
        public Program(int n)
        {
            MakeSort(n);
        }
        void MakeSort(int n)
        {
            int[] testIntArray = new [] { 22, 3, 41, 5, 6, 71, 8, 9, 5, 6, 4, 34, 65, 76, 23, 54, 23, 65, 12, 43, 09, 76, 66, 5 };
            var testStringArray = new[] {"hello","world","morning","Hello","eye","CAT","dog","DOG","greatings","compucter","try","in" };

            var sorter = new Sorter<int>(testIntArray,new Bubble_sort<int>());
            sorter.ArraySort();
            Console.WriteLine(sorter.ToString());

            var sorter2 = new Sorter<string>(testStringArray, new Bubble_sort<string>());
            sorter2.ArraySort();
            Console.WriteLine(sorter2.ToString());
        }
    }
}
