namespace DataStructures.Classes
{
    internal class BinarySearchTreeDemo
    {
        /**
         * Binary Search Tree does not require a separate Node class.
         * The BinarySearchTreeDemo class itself represents the nodes of the tree.
         */

        public int value;
        public BinarySearchTreeDemo? left;
        public BinarySearchTreeDemo? right;

        public int Count { get; private set; }

        public BinarySearchTreeDemo(int value)
        {
            this.value = value;

            Count = 1;
        }

        public void Insert(int num)
        {
            if (value > num)
            {
                if (left is null)
                {
                    left = new BinarySearchTreeDemo(num);
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
                    right = new BinarySearchTreeDemo(num);
                }

                else
                {
                    right.Insert(num);
                }
            }

            Count++;
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

        public int Sum()
        {
            var sum = value;

            if (left is not null)
                sum += left.Sum();

            if (right is not null)
                sum += right.Sum();

            return sum;
        }

        public int Min()
        {
            if (left is null)
                return value;

            return left.Min();
        }

        public bool Equals(BinarySearchTreeDemo? tree)
        {
            if (Count !=  tree?.Count)
                return false;

            if (value != tree.value)
                return false;

            if (left is not null)
                return left.Equals(tree.left);

            if (left is not null)
                return left.Equals(tree.left);

            return true;
        }

        public int Height()
        {
            static int Calculate(BinarySearchTreeDemo? root)
            {
                if (root is null)
                    return -1;

                if (root.right is null && root.left is null)
                    return 0;

                return 1 + Math.Max(Calculate(root.left), Calculate(root.right));
            }

            return Calculate(this);
        }

        public int[] FindModes() // Solved on LeetCode 501
        {
            var dic = new Dictionary<int, int>();

            void CollectData(BinarySearchTreeDemo root)
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

        public IEnumerable<int> TraversePerOrder()
        {
            yield return value;

            if (left is not null)
                foreach (var i in left.TraverseInOrder())
                    yield return i;

            if (right is not null)
                foreach (var i in right.TraverseInOrder())
                    yield return i;
        }

        public IEnumerable<int> TraverseInOrder()
        {
            if (left is not null)
                foreach (var i in left.TraverseInOrder())
                    yield return i;

            yield return value;

            if (right is not null)
                foreach (var i in right.TraverseInOrder())
                    yield return i;
        }

        public IEnumerable<int> TraversePostOrder()
        {
            if (left is not null)
                foreach (var i in left.TraversePostOrder())
                    yield return i;

            if (right is not null)
                foreach (var i in right.TraversePostOrder())
                    yield return i;

            yield return value;
        }
    }
}
