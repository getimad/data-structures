namespace DataStructures.Classes.Helpers
{
    public class Tree
    {
        public int Value { get; set; }
        public Tree? Left { get; set; }
        public Tree? Right { get; set; }
        public int Height { get; set; }

        public Tree(int val = 0, Tree? left = null, Tree? right = null)
        {
            Value = val;
            Left = left;
            Right = right;
        }
    }
}
