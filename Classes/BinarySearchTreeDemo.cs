using DataStructures.Classes.Helpers;

namespace DataStructures.Classes
{
    internal class BinarySearchTreeDemo
    {
        public Tree? Root { get; private set; }

        public void Add(int val)
        {
            if (Root is null)
                Root = new Tree(val);

            else
                Add(Root, val);
        }

        private void Add(Tree current, int val)
        {
            if (val <= current.Value)
            {
                if (current.Left is null)
                    current.Left = new Tree(val);

                else
                    Add(current.Left, val);
            }

            else
            {
                if (current.Right is null)
                    current.Right = new Tree(val);

                else
                    Add(current.Right, val);
            }
        }

        public bool Contains(int val)
        {
            if (Root is null)
                throw new NullReferenceException("The Binary Search Tree is empty.");

            return Contains(Root, val);
        }
        
        private bool Contains(Tree current, int val)
        {
            if (val < current.Value)
            {
                if (current.Left is null)
                    return false;

                return Contains(current.Left, val);
            }

            if (val > current.Value)
            {
                if (current.Right is null)
                    return false;

                return Contains(current.Right, val);
            }

            return true;
        }

        public int Sum()
        {
            if (Root is null)
                throw new NullReferenceException("The Binary Search Tree is empty.");

            return Sum(Root);
        }
            

        private int Sum(Tree current)
        {
            if (current is null)
                return 0;

            if (current.Left is null || current.Right is null)
                return 0;

            return current.Value + Sum(current.Right) + Sum(current.Left);
        }

        public int Min()
        {
            if (Root is null)
                throw new NullReferenceException("The Binary Search Tree is empty.");

            return Min(Root);
        }

        private int Min(Tree current)
        {
            if (current.Left is null)
                return current.Value;

            return Min(current.Left);
        }

        public int Max()
        {
            if (Root is null)
                throw new NullReferenceException("The Binary Search Tree is empty.");

            return Max(Root);
        }

        private int Max(Tree current)
        {
            if (current.Right is null)
                return current.Value;

            return Max(current.Right);
        }

        public bool Equals(BinarySearchTreeDemo other)
        {
            if (other is null)
                throw new ArgumentNullException(nameof(other));

            if (Root is null && other.Root is null)
                return true;

            if (Root is null || other.Root is null)
                return false;

            return Equals(Root, other.Root);
        }

        private bool Equals(Tree current, Tree other)
        {
            if (current.Value != other.Value)
                return false;

            if (current.Left is null ^ other.Left is null)
                return false;

            if (current.Left is not null && other.Left is not null)
                return Equals(current.Left, other.Left);

            if (current.Right is not null && other.Right is not null)
                return Equals(current.Right, other.Right);

            return true;
        }

        public int Height()
        {
            if (Root is null)
                return -1;

            return Height(Root);
        }

        private int Height(Tree current)
        {
            if (current.Left is null || current.Right is null)
                return 1;

            return 1 + Math.Max(Height(current.Left), Height(current.Right));
        }

        public IEnumerable<int> TraversePerOrder()
        {
            if (Root is null)
                throw new NullReferenceException("The Binary Search Tree is empty.");

            return TraversePerOrder(Root);
        }

        private IEnumerable<int> TraversePerOrder(Tree current)
        {
            yield return current.Value;

            if (current.Left is not null)
                foreach (var i in TraversePerOrder(current.Left))
                    yield return i;

            if (current.Right is not null)
                foreach (var i in TraversePerOrder(current.Right))
                    yield return i;
        }

        public IEnumerable<int> TraverseInOrder()
        {
            if (Root is null)
                throw new NullReferenceException("The Binary Search Tree is empty.");

            return TraverseInOrder(Root);
        }

        private IEnumerable<int> TraverseInOrder(Tree current)
        {
            if (current.Left is not null)
                foreach (var i in TraverseInOrder(current.Left))
                    yield return i;

            yield return current.Value;

            if (current.Right is not null)
                foreach (var i in TraverseInOrder(current.Right))
                    yield return i;
        }

        public IEnumerable<int> TraversePostOrder()
        {
            if (Root is null)
                throw new NullReferenceException("The Binary Search Tree is empty.");

            return TraversePostOrder(Root);
        }

        private IEnumerable<int> TraversePostOrder(Tree current)
        {
            if (current.Left is not null)
                foreach (var i in TraversePostOrder(current.Left))
                    yield return i;

            if (current.Right is not null)
                foreach (var i in TraversePostOrder(current.Right))
                    yield return i;

            yield return current.Value;
        }
    }
}
