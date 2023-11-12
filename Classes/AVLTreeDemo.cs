using DataStructures.Classes.Helpers;

namespace DataStructures.Classes
{
    internal class AVLTreeDemo
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

            current.Height = Math.Max(Height(current.Left), Height(current.Right)) + 1;
        }

        private static int Height(Tree? current)
            => current is null ? -1 : current.Height;
    }
}
