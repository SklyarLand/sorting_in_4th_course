using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algoritmen;

namespace Controllers
{
    public class MainController
    {
        public int arrayLength;
        int[] sizes;
        BaseSort[] sorts;

        public MainController()
        {
            this.sizes = new int[] { 10000, 30000, 50000, 70000, 100000, 500000,1000000, 2000000 };
            this.sorts = new BaseSort[] { new TreeSort(), new ShellSortPratt()};
        }

        public MainController(int[] sizes, BaseSort[] sorts)
        {
            this.sizes = sizes;
            this.sorts = sorts;
        }

        public Dictionary<string, Dictionary<int, long>> MakeSort()//
        {
            var res = new Dictionary<string, Dictionary<int,long>>();
            foreach (var sort in sorts)
            {
                var dict = new Dictionary<int, long>();
                foreach (var size in sizes)
                {
                    int[] testIntArray = CreateArray(size);
                    var sorter = new Sorter(testIntArray, sort);
                    sorter.ArraySort();
                    dict.Add(size, sorter.milliseconds);
                }
                res.Add(sort.Name, dict);
            }
            return res;
        }

        public int[] CreateArray(int n) {//возвращает массив рандомных чисел
            int[] arr = new int [n];
            var random = new Random();
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(n * 10);
            }
            return arr;
        }
    }
}
