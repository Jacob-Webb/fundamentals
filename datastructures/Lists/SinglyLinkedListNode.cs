using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructures.Lists
{
    public class Node<T>
      {
        public Node<T> Next { get; set; }
        public T Element { get; set; }

        public Node(int v)
        {
          Next = null;
          Element = default(T);
        }
        public Node(T element)
        {
          Element = element;
          Next = null;
        }
        public Node(T element, Node<T> nextNode)
        {
          Next = nextNode;
          Element = element;
        }
      }
}