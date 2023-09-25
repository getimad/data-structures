namespace DataStructures
{
    internal class QueueDemo
    {
        private class Node
        {
            public int value;
            public Node next;

            public Node(int value)
            {
                this.value = value;
            }
        }

        private Node _head;
        private Node _tail;

        /// <summary>
        /// Add the number to the end of the queue.
        /// </summary>
        /// <param name="num"></param>
        public void Enqueue(int num)
        {
            var node = new Node(num);

            if (_head == null)
            {
                _head = _tail = node;
            }

            else
            {
                _tail.next = node;
                _tail = node;
            }
        }

        /// <summary>
        /// Removes the number at the head of the queue and returns it.
        /// </summary>
        /// <returns></returns>
        public int Dequeue()
        {
            var num = _head.value;
            _head = _head.next;

            return num;
        }

        /// <summary>
        /// Returns the the head of the queue.
        /// </summary>
        /// <returns></returns>
        public int Peek()
        {
            return _tail.value;
        }
        
        /// <summary>
        /// Check if the queue is empty or not.
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return _head == null;
        }
    }
}
