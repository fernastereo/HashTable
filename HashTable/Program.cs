using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashTable = new HashTable<int>(3);

            hashTable.Add("One", 1);
            hashTable.Add("Two", 2);
            hashTable.Add("Three", 3);

            Console.WriteLine(hashTable.Get("Three"));
            Console.WriteLine(hashTable.Get("One"));
            Console.WriteLine(hashTable.Get("Two"));
        }
    }
}
