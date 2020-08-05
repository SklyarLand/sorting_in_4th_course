using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace Algoritmen
{
    public class Sorter   //сортировщик
    {   
        private int[] array;
        private ISort Sort;
        public long milliseconds { get; set; }

        public Sorter(int[] array, ISort sort)//конструктор сортировщика,принимает массив и вид сортировки
        {
            this.array = array;
            Sort = sort;
        }

        public void ArraySort()             //сортировка массива
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Sort.Algorithm(array);
            stopwatch.Stop();
            milliseconds = stopwatch.ElapsedMilliseconds;
        }

        public override string ToString()//вывод массива
        {
            StringBuilder stringB = new StringBuilder();
            foreach (var item in array)
                stringB.AppendFormat(item+" ");
            return stringB.ToString();
        }
    }
}
