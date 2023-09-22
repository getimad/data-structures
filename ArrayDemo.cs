namespace DataStructures
{
    internal class ArrayDemo
    {
        private int[] _array;
        private int _count;

        public ArrayDemo(int size)
        {
            _array = new int[size];
        }

        /// <summary>
        /// Make the array indexer to simplify the syntax
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int this[int index]
        {
            get => _array[index];
            set => _array[index] = value;
        }

        /// <summary>
        /// Return the size of the array.
        /// </summary>
        public int Size
        {
            get => _array.Length;
        }

        /// <summary>
        /// Insert new item to the end of the array.
        /// </summary>
        /// <param name="item"></param>
        public void Insert(int item)
        {
            _array[_count] = item;

            _count++;
        }

        /// <summary>
        /// Remove an item in a specific index.
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            int[] newArr = new int[Size];

            for (int i = 0, j = 0; i < Size; i++)
            {
                if (i != index)
                {
                    newArr[j] = _array[i];
                    j++;
                }
            }

            _array = newArr;
            _count--;
        }

        /// <summary>
        /// Return the index of the giving item.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int IndexOf(int item)
        {
            for (int i = 0; i < Size; i++)
            {
                if (_array[i] == item)
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Print all the elements of the array on the console.
        /// </summary>
        public void Print()
        {
            foreach (int item in _array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
