using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class BinTree<T> : IEnumerable<T> where T : IComparable
    {
        private Node<T> _root;

        public void Put(T key)
        {
            Node<T> currentNode = new Node<T>();
            currentNode.key = key;

            if (_root == null)
            {
                _root = currentNode;
                return;
            }

            Node<T> temp = _root;

            Node<T> parent = temp;

            while (temp != null)
            {
                parent = temp;

                if (currentNode.CompareTo(temp) < 0)
                {
                    temp = temp.left;
                }
                else if (currentNode.CompareTo(temp) > 0)
                {
                    temp = temp.right;
                }
                else if (currentNode.CompareTo(temp) == 0)
                {
                    temp = temp.right;
                }
            }

            if (currentNode.CompareTo(parent) < 0)
            {
                parent.left = currentNode;
            }
            else if (currentNode.CompareTo(parent) > 0)
            {
                parent.right = currentNode;
            }
            else if (currentNode.CompareTo(parent) == 0)
            {
                parent.right = currentNode;
            }
        }

        public class Node<K> : IComparable<Node<K>> where K : IComparable
        {
            public K key;
            public Node<K> left;
            public Node<K> right;

            public int CompareTo(Node<K> other)
            {
                return key.CompareTo(other.key);
            }
        }

        private LinkedList<T> EntryList()
        {
            LinkedList<T> list = new LinkedList<T>();
            return CLR(_root, list);
        }

        private LinkedList<T> CLR(Node<T> node, LinkedList<T> list)
        {
            if (node != null)
            {
                list.AddLast(node.key);
                CLR(node.left, list); 
                CLR(node.right, list); 
            }
            return list;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var K in EntryList())
            {
                yield return K;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}