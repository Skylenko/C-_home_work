using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable hashTable = new HashTable();
            hashTable.Add("1", 8);

            hashTable[9] = 89;
            Console.WriteLine(hashTable[9]);
            Console.ReadLine();
       
        }
    }
}
