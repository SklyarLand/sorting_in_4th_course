using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen
{
    public class ShakerSort : BaseSort
    {
        public ShakerSort()
        {
            sortName = "Коктельная сортировка";
        }
        public override void Algorithm(int[] array)
        {
            int left = 0,
                right = array.Length - 1,
                count = 0;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    count++;
                    if (array[i].CompareTo(array[i + 1]) > 0 )
                        Swap(array, i, i + 1);
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    count++;
                    if (array[i - 1].CompareTo(array[i]) > 0)
                        Swap(array, i - 1, i);
                }
                left++;
            }
        }
    }
}
