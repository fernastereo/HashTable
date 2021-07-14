using System;
using System.Collections.Generic;
using System.Text;
using HashTable;
using Xunit;

namespace HashTableTests
{
    public class HashTableTests
    {
        [Fact]
        public void Get_WithAnExistingKey_ReturnTheValue()
        {
            const string keyToGet = "One";
            const int valueToGet = 1;

            var hashTable = CreateHashTable();

            var result = hashTable.Get(keyToGet);

            Assert.Equal(valueToGet, result);
        }

        [Fact]
        public void Get_WithAnUnExistingKey_ReturnArgumentOutOfRangeException()
        {
            var hashTable = CreateHashTable();

            Assert.Throws<ArgumentOutOfRangeException>(() => hashTable.Get(Guid.NewGuid().ToString()));
        }

        [Fact]
        public void Add_WithNodeToCreate_ReturnsCreatedNode()
        {
            const string keyToCreate = "Four";
            const int valueToCreate = 4;

            var hashTable = CreateHashTable();
            hashTable.Add(keyToCreate, valueToCreate);

            var result = hashTable.Get(keyToCreate);

            Assert.Equal(valueToCreate, result);
        }

        [Fact]
        public void Delete_WithExistingNode_ReturnsTrueWhenDeleted()
        {
            const string keyToDelete = "One";

            var hashTable = CreateHashTable();
            
            var result = hashTable.Delete(keyToDelete);

            Assert.True(result);
        }

        [Fact]
        public void Add_WithUnexistingNode_ReturnsFalse()
        {
            const string keyToDelete = "Four";

            var hashTable = CreateHashTable();

            var result = hashTable.Delete(keyToDelete);

            Assert.False(result);
        }

        private HashTable<int> CreateHashTable()
        {
            var hashTable = new HashTable<int>(4);
            hashTable.Add("One", 1);
            hashTable.Add("Two", 2);
            hashTable.Add("Three", 3);
            return hashTable;
        }
    }
}
