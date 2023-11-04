using DataStructures.Classes.Helpers;

namespace DataStructures.Classes
{
    internal class LinkedListDemo
    {
        public Node? Head { get; private set; }
        public Node? Tail { get; private set; }

        public void AddFirst(int val)
        {
            var node = new Node(val);

            if (Head is null)
                Head = Tail = node;

            else
            {
                node.Next = Head;
                Head = node;
            }
        }

        public void AddLast(int val)
        {
            var node = new Node(val);

            if (Head is null || Tail is null)
                Head = Tail = node;

            else
            {
                Tail.Next = node;
                Tail = node;
            }
        }

        public int RemoveFirst()
        {
            if (Head is null)
                throw new NullReferenceException("The Linked List is empty.");

            var value = Head.Value;

            if (Head.Next is null)
                Head = Tail = null;
            else
                Head = Head.Next;

            return value;
        }

        public int RemoveLast()
        {
            if (Head is null || Tail is null)
                throw new NullReferenceException("The Linked List is empty.");

            var value = Tail.Value;

            if (Head.Next is null)
                Head = Tail = null;
            else
            {
                var current = Head;

                while (current is not null)
                {
                    if (current.Next.Equals(Tail))
                    {
                        Tail = current;
                        Tail.Next = null;
                    }

                    current = current.Next;
                }
            }

            return value;
        }

        public int Size()
        {
            var size = 0;
            var current = Head;

            if (current is null)
                return size;

            while (current is not null)
            {
                size++;
                current = current.Next;
            }

            return size;
        }

        public int IndexOf(int val)
        {
            var index = 0;

            var current = Head;

            while (current is not null)
            {
                if (current.Value == val)
                    return index;

                current = current.Next;
                index++;
            }

            return -1;
        }

        public bool Contains(int val)
            => IndexOf(val) != -1;

        public void Reverse()
        {
            if (Head is null)
                throw new NullReferenceException("The Linked List is empty.");

            var preNode = Head;
            var curNode = Head.Next;

            while (curNode is not null)
            {
                var nextNode = curNode.Next;
                curNode.Next = preNode;
                preNode = curNode;
                curNode = nextNode;
            }

            Tail = Head;
            Tail.Next = null;

            Head = preNode;
        }

        public int[] ConverToArray()
        {
            var list = new List<int>();

            var current = Head;

            while (current is not null)
            {
                list.Add(current.Value);
                current = current.Next;
            }

            return list.ToArray();
        }
    }
}
