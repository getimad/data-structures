using System;
using System.Collections.Generic;

namespace DataStructures.Classes
{
    internal class BinaryTreeDemo
    {
        /**
         * Binary Tree does not require a separate Node class.
         * The BinaryTree class itself represents the nodes of the tree.
         */

        public int value;
        public BinaryTreeDemo left;
        public BinaryTreeDemo right;

        public BinaryTreeDemo(int value)
        {
            this.value = value;
        }

        public void Insert(int num)
        {
            if (value > num)
            {
                if (left is null)
                {
                    left = new BinaryTreeDemo(num);
                }

                else
                {
                    left.Insert(num);
                }
            }

            else
            {
                if (right is null)
                {
                    right = new BinaryTreeDemo(num);
                }

                else
                {
                    right.Insert(num);
                }
            }
        }

        public bool Contains(int num)
        {
            if (value == num)
            {
                return true;
            }

            if (value > num)
            {
                if (left is null)
                {
                    return false;
                }

                else
                {
                    return left.Contains(num);
                }
            }

            else
            {
                if (right is null)
                {
                    return false;
                }

                else
                {
                    return right.Contains(num);
                }
            }
        }

        
        public int[] FindModes() // Solved on LeetCode 501
        {
            var dic = new Dictionary<int, int>();

            void CollectData(BinaryTreeDemo root)
            {
                if (!dic.TryAdd(root.value, 1))
                {
                    dic[root.value]++;
                }

                if (root.left is null && root.right is null)
                {
                    return;
                }

                if (root.left is not null)
                {
                    CollectData(root.left);
                }

                if (root.right is not null)
                {
                    CollectData(root.right);
                }
            }

            CollectData(this);

            var max = dic.Max(x => x.Value);
            var modes = new List<int>();
            
            foreach (var item in dic)
            {
                if (item.Value.Equals(max))
                {
                    modes.Add(item.Key);
                }
            }

            return modes.ToArray();
        }
    }
}
