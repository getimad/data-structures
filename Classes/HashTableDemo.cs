using DataStructures.Classes.Helpers;

namespace DataStructures.Classes
{
    internal class HashTableDemo
    {
        public int Size { get; private set; }
        private List<Pair>[] Data { get; set; }

        public HashTableDemo(int size = 64)
        {
            Size = size;
            Data = new List<Pair>[size];
        }

        private int GetBucketIndex(int key)
            // Get Hash of the key.
            => key % Size;

        public void Put(int key, int val)
        {
            var pair = new Pair(key, val);

            var index = GetBucketIndex(key);
            Data[index] ??= new List<Pair>();

            for (var i = 0; i < Data[index].Count; i++)
            {
                if (Data[index][i].Equals(key))
                {
                    Data[index][i] = pair;
                    return;
                }
            }

            Data[index].Add(pair);
        }

        public int Get(int key)
        {
            var index = GetBucketIndex(key);
            Data[index] ??= new List<Pair>();

            for (var i = 0; i < Data[index].Count; i++)
            {
                if (Data[index][i].Key.Equals(key))
                    return Data[index][i].Value;
            }

            return -1;
        }

        public bool Contains(int key)
            => Get(key) != -1;

        public void Remove(int key)
        {
            if (!Contains(key))
                throw new KeyNotFoundException("The key is not exist in the Hash Table.");

            var index = GetBucketIndex(key);

            Data[index] ??= new List<Pair>();

            for (var i = 0; i < Data[index].Count; i++)
            {
                if (Data[index][i].Key.Equals(key))
                {
                    Data[index].RemoveAt(i);
                    break;
                }
            }
        }
    }
}
