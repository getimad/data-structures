namespace DataStructures.Classes
{
    internal class LinkedListDemo
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

        private Node _first;
        private Node _last;

        /// <summary>
        /// Add the number at the end of the linked list.
        /// </summary>
        /// <param name="num"></param>
        public void AddLast(int num)
        {
            var node = new Node(num);

            if (_first == null)
            {
                _first = _last = node;
            }

            else
            {
                _last.next = node;
                _last = node;
            }
        }

        /// <summary>
        /// Add the number at the first of the linked list.
        /// </summary>
        /// <param name="num"></param>
        public void AddFirst(int num)
        {
            var node = new Node(num);

            if (_first == null)
            {
                _first = _last = node;
            }

            else
            {
                node.next = _first;
                _first = node;
            }
        }

        /// <summary>
        /// Index of the num in linked list.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int IndexOf(int num)
        {
            var count = 0;

            var node = _first;

            while (true)
            {
                if (node.next == null)
                {
                    return -1;
                }

                if (node.value == num)
                {
                    return count;
                }

                node = node.next;
                count++;
            }
        }

        /// <summary>
        /// Check if the linked list contains the number.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool Contains(int num)
        {
            var node = _first;

            while (true)
            {
                if (node == null)
                {
                    return false;
                }

                if (node.value == num)
                {
                    return true;
                }

                node = node.next;
            }
        }

        /// <summary>
        /// Remove the first number in the linked list.
        /// </summary>
        /// <exception cref="NullReferenceException"></exception>
        public void RemoveFirst()
        {
            if (_first == null)
            {
                throw new NullReferenceException();
            }

            if (_first.next == null)
            {
                _first = _last = null;
                return;
            }

            _first = _first.next;
        }

        /// <summary>
        /// Remove the last number in the linked list.
        /// </summary>
        /// <exception cref="NullReferenceException"></exception>
        public void RemoveLast()
        {
            if (_first == null)
            {
                throw new NullReferenceException();
            }

            if (_first.next == null)
            {
                _first = _last = null;
                return;
            }

            var node = _first;
            var next = _first.next;

            while (true)
            {
                if (next.next == null)
                {
                    _last = node;
                    _last.next = null;
                    return;
                }

                node = node.next;
                next = next.next;
            }
        }

        /// <summary>
        /// Reverse the linked list.
        /// </summary>
        public void Reverse()
        {
            var preNode = _first;
            var curNode = _first.next;

            while (true)
            {
                if (curNode == null)
                {
                    break;
                }

                var nexNode = curNode.next;
                curNode.next = preNode;
                preNode = curNode;
                curNode = nexNode;
            }

            _last = _first;
            _last.next = null;

            _first = preNode;
        }

        /// <summary>
        /// Returns the size of the linked list.
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            var count = 0;
            var node = _first;

            while (true)
            {
                if (node == null)
                {
                    return count;
                }

                node = node.next;
                count++;
            }
        }

        /// <summary>
        /// Get the Kth from the end of the list.
        /// </summary>
        /// <param name="kth"></param>
        /// <returns></returns>
        public int GetKthFromTheEnd(int kth)
        {
            var x = _first;
            var y = _first;

            for (var i = 0; i < kth - 1; i++)
            {
                x = x.next;
            }

            while (true)
            {
                if (x == _last)
                {
                    return y.value;
                }

                x = x.next;
                y = y.next;
            }
        }

        /// <summary>
        /// Return converted linked list to array.
        /// </summary>
        /// <returns></returns>
        public int[] ConverToArray()
        {
            var array = new int[Size()];
            var index = 0;

            var node = _first;

            while (true)
            {
                if (node == null)
                {
                    return array;
                }

                array[index++] = node.value;
                node = node.next;
            }
        }
    }
}
