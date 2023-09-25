namespace DataStructures
{
    internal class StackDemo
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

        private Node _top;

        /// <summary>
        /// Push the number to the top of the stack.
        /// </summary>
        /// <param name="num"></param>
        public void Push(int num)
        {
            var node = new Node(num);

            if (_top == null)
            {
                _top = node;
            }

            else
            {
                node.next = _top;
                _top = node;
            }
        }

        /// <summary>
        /// Pop the last number from the stack.
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            var num = _top.value;
            _top = _top.next;

            return num;
        }

        /// <summary>
        /// Return the top number of the stack.
        /// </summary>
        /// <returns></returns>
        public int Peek()
        {
            return _top.value;
        }

        /// <summary>
        /// Check if the stack is empty.
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return _top == null;
        }
    }
}
