using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen
{
    public class BubbleSort : BaseSort
    {//конкретная сортировка
        public BubbleSort()
        {
            sortName = "Пузырьковая сортировка";
        }
        public override void Algorithm(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i].CompareTo(array[j]) > 0)
                    {
                        Swap(array, i, j);
                    }
        }
    }
}
