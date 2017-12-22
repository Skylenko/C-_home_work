using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHashTable
{
    class HashTable : IHashTable
    {
        internal class HashTableEntry
        {
            internal object key;
            internal object value;
        }

        HashTableEntry[] hashTable = new HashTableEntry[10];

        public bool Contains(object key)
        {
            throw new System.NotImplementedException();
        }

        public void Add(object key, object value)
        {
            int hashCode = key.GetHashCode();
            int index = indexFor(hashCode, hashTable.Length);

            HashTableEntry hashTableEntry = new HashTableEntry();
            hashTableEntry.key = key;
            hashTableEntry.value = value;

            hashTable[index] = hashTableEntry;
        }

        static int indexFor(int h, int length)
        {
            return h & (length - 1);
        }

        public object this[object key]
        {
            get
            {
                HashTableEntry hashTableEntry = new HashTableEntry();
                int hashCode = key.GetHashCode();
                int index = indexFor(hashCode, hashTable.Length);
                return index;
            }
            set
            {
                HashTableEntry hashTableEntry = new HashTableEntry();

                hashTableEntry.value = value;

            }
        }

        public bool TryGet(object key, out object value)
        {
            int index = indexFor(key.GetHashCode(), hashTable.Length);
            HashTableEntry res = hashTable[index];
            if (res == null)
            {
                throw new Exception();
            }
            value = res.value;
            return true;
        }
    }
}