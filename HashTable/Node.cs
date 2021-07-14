using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public string Key { get; set; }
        public T Value { get; set; }
    }
}
