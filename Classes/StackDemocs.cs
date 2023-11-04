using DataStructures.Classes.Helpers;

namespace DataStructures.Classes
{
    internal class StackDemo
    {
        public Node? Top { get; private set; }

        public void Push(int num)
            => Top = new Node(num, Top);

        public int Pop()
        {
            if (Top is null)
                throw new InvalidOperationException("The Stack is empty.");

            var value = Top.Value;

            Top = Top.Next;

            return value;
        }

        public int Peek()
        {
            if (Top is null)
                throw new InvalidOperationException("The Stack is empty.");

            return Top.Value;
        }

        public bool IsEmpty()
            => Top is null;

        public void Clear()
            => Top = null;

        public int[] ConvertToArray()
        {
            var list = new List<int>();
            var current = Top;

            while (current is not null)
            {
                list.Add(current.Value);
                current = current.Next;
            }

            return list.ToArray();
        }
    }
}
