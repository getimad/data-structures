namespace DataStructures.Classes.Helpers
{
    public class Node
    {
        public int Value { get; set; }
        public Node? Next { get; set; }

        public Node(int value = 0, Node? next = null)
        {
            Value = value;
            Next = next;
        }
    }
}
