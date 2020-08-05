using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen
{
    public class TreeSort : BaseSort
    {
        public TreeSort()
        {
            sortName = "Двоичное дерево";
        }
        class TreeNode
        {
            public int Data { get; set; }
            public TreeNode Left { get; set; }
            public TreeNode Right { get; set; }

            public TreeNode(int data)
            {
                Data = data;
            }
            public void Insert(TreeNode node)
            {
                if (Data.CompareTo(node.Data) > 0)
                {
                    if (Left == null)
                    {
                        Left = node;
                    }
                    else
                    {
                        Left.Insert(node);
                    }
                }
                else
                {
                    if (Right == null)
                    {
                        Right = node;
                    }
                    else
                    {
                        Right.Insert(node);
                    }
                }
            }

            public void Transform(ref int[] array, ref int index)
            {
                if (Left != null)
                {
                    Left.Transform(ref array, ref index);
                }

                array[index] = Data;
                index++;
                if (Right != null)
                {
                    Right.Transform(ref array, ref index);
                }
            }
        }
        public override void Algorithm(int[] array)
        {
            var tree = new TreeNode(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                tree.Insert(new TreeNode(array[i]));
            }
            int index = 0;
            tree.Transform(ref array, ref index);
        }
    }
}
