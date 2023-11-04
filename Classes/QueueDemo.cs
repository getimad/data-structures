using DataStructures.Classes.Helpers;

namespace DataStructures.Classes
{
    internal class QueueDemo
    {
        public Node? Front { get; private set; }
        public Node? Rear { get; private set; }

        public void Enqueue(int val)
        {
            // Add new node to the rear of the Queue.

            var node = new Node(val);

            if (Front is null || Rear is null)
                Front = Rear = node;

            else
            {
                Rear.Next = node;
                Rear = node;
            }
        }

        public int Dequeue()
        {
            // Remove the front node of the Queue.

            if (Front is null)
                throw new NullReferenceException("The Queue is empty.");

            var value = Front.Value;
            Front = Front.Next;

            return value;
        }

        public int Peek()
        {
            if (Front is null)
                throw new NullReferenceException("The Queue is empty.");

            return Front.Value;
        }

        public bool IsEmpty()
            => Front == null;

        public void Clear()
            => Front = null;

        public int[] ConvertToArray()
        {
            var list = new List<int>();
            var current = Front;

            while (current is not null)
            {
                list.Add(current.Value);
                current = current.Next;
            }

            return list.ToArray();
        }
    }
}
