using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen
{
    public class HeapSort : BaseSort
    {
        public HeapSort()
        {
            this.sortName = "Пирамидальная сортировка";
        }
        public override void Algorithm(int[] array)
        {
            int size = array.Length;
            for (int i = (size / 2) - 1; i >= 0; i--)
                siftDown(array, i, size - 1);
            // Просеиваем через пирамиду остальные элементы
            for (int i = size - 1; i >= 1; i--)
            {
                Swap(array, 0, i);
                siftDown(array, 0, i - 1);
            }
        }
        void siftDown(int[] array, int root, int bottom)
        {
            int maxChild; // индекс максимального потомка
            bool done = false; // флаг того, что куча сформирована
                          // Пока не дошли до последнего ряда
            while ((root * 2 <= bottom) && !done)
            {
                if (root * 2 == bottom)    // если мы в последнем ряду,
                    maxChild = root * 2;    // запоминаем левый потомок
                                            // иначе запоминаем больший потомок из двух
                else if (array[root * 2] > array[root * 2 + 1])
                    maxChild = root * 2;
                else
                    maxChild = root * 2 + 1;
                // если элемент вершины меньше максимального потомка
                if (array[root] < array[maxChild])
                {
                    Swap(array, root, maxChild);
                    root = maxChild;
                }
                else done = true; // пирамида сформирована
            }
        }
    }
}
