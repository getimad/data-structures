namespace DataStructures
{
    internal class HashTableDemo
    {
        private class Entry
        {
            public int key;
            public string value;

            public Entry(int key, string value)
            {
                this.key = key;
                this.value = value;
            }
        }

        private LinkedList<Entry>[] _entries = new LinkedList<Entry>[5];

        /// <summary>
        /// Add an entry to the hash table if not exist otherwize update the existing entry.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Put(int key, string value)
        {
            var index = Hash(key);

            if (_entries[index] == null)
            {
                _entries[index] = new LinkedList<Entry>();
            }

            var bucket = _entries[index];

            foreach (var entry in bucket)
            {
                if (entry.key == key)
                {
                    entry.value = value;
                    return;
                }
            }

            bucket.AddLast(new Entry(key, value));
        }

        /// <summary>
        /// Returns the value by its key from hash table.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string Get(int key)
        {
            var index = Hash(key);

            var bucket = _entries[index];

            foreach (var entry in bucket)
            {
                if (entry.key == key)
                {
                    return entry.value;
                }
            }

            return null;
        }

        /// <summary>
        /// Remove an entry by its key from hash table.
        /// </summary>
        /// <param name="key"></param>
        public void Remove(int key)
        {
            var index = Hash(key);

            var bucket = _entries[index];

            foreach(var entry in bucket)
            {
                if (entry.key == key)
                {
                    bucket.Remove(entry);
                    return;
                }
            }
        }

        /// <summary>
        /// Returns hash of a number.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private int Hash(int key)
        {
            return key % _entries.Length;
        }
    }
}
