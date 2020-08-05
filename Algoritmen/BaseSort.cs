using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen
{
    abstract public class BaseSort : ISort
    {
        protected string sortName = "Базовая сортировка";
        public abstract void Algorithm(int[] array);

        protected void Swap(int[] array, int i, int j)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        
        public string Name { get { return this.sortName; } }
    }
}
