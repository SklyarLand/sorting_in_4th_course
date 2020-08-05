using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen
{
    public class ShellSort : BaseSort
    {
        public ShellSort()
        {
            this.sortName = "Соритровка Шелла";
        }
        public override void Algorithm(int[] array)
        {
            for (int inc = array.Length / 2; inc >= 1; inc = inc / 2)
                for (int step = 0; step < inc; step++)
                    insertionSort(array, step, inc);
        }

        private void insertionSort(int[] arr, int start, int inc)
        {
            for (int i = start; i < arr.Length - 1; i += inc)
                for (int j = Math.Min(i + inc, arr.Length - 1); j - inc >= 0; j = j - inc)
                    if (arr[j - inc] > arr[j])
                    {
                        Swap(arr, j, j - inc);
                    }
                    else break;
        }
    }
}
