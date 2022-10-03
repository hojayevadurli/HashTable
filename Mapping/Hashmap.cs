using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Hash Map then I will use it in 
namespace Mapping
{
    class Hashmap<K, V>
    {

        // Hash map Implementation
        //ArrayList of LinkedLists with Tuple inside
        public List<LinkedList<Tuple<K, V>>> table;
        public Hashmap(int size = 100)
        {
            table = new List<LinkedList<Tuple<K, V>>>(size);

            for (int i = 0; i < size; i++)
            {
                // I want to append new Linkedlist to the end of my table
                table.Add(new LinkedList<Tuple<K, V>>());
            }
        }


        //get the key value, look for LinkedList
        public V Get(K key)
        {


            //check every node of the linkedlist if the key value exist
            foreach (var (nodeKey, nodeValue) in GetBucket(key))
            {
                if (key.Equals(nodeKey))
                {
                    return nodeValue;
                    Console.WriteLine("this is the student"+ nodeValue);

                }

            }
            throw new ArgumentException("Oops cannot find that student");

        }





        //it returns the linkedlist that is colliding with the key
        public LinkedList<Tuple<K, V>> GetBucket(K key)
        {
            //hash the key value
            int hashCode = Math.Abs(key.GetHashCode());

            //to assign the index that I took out from by moduling the hash code 
            //getting the Index to look for the index
            int ArrayListIndex = hashCode % table.Count;

            //go to that LinkedList in that index
            //LinkedList<Tuple<K, V>> bucket = table[ArrayListIndex];
            var bucket = table[ArrayListIndex];

            return bucket;

        }

        ////put student information
        public void Put(K key, V value)
        {
            LinkedList<Tuple<K, V>> storage = GetBucket(key);

            //remove if it is already there
            foreach (var node in storage)
            {
                if (key.Equals(node.Item1))
                {
                    storage.Remove(node);
                }


            }

            storage.AddLast(Tuple.Create(key, value));


        }








    }
}

