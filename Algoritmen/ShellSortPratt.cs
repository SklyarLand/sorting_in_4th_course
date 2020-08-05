using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen
{
    public class ShellSortPratt : BaseSort
    {
        public ShellSortPratt()
        {
            sortName = "Сортировка Шелла-Пратта";
        }
        public override void Algorithm(int[] array)
        {
            var d = array.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < array.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && (array[j - d].CompareTo(array[j]) > 0))
                    {
                        Swap(array, j, j - d);
                        j = j - d;
                    }
                }
                d = d / 2;
            }
        }
    }
}
