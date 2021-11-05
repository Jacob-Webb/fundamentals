using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces;

namespace DataStructures.Lists
{
    public class SinglyLinkedListNode<T> : ILinkedListNode<T>
      {
        public ILinkedListNode<T> Next { get; set; }
        public T Value { get; set; }

        public SinglyLinkedListNode(int v)
        {
          Next = null;
          Value = default(T);
        }
        public SinglyLinkedListNode(T value)
        {
          Value = value;
          Next = null;
        }
        public SinglyLinkedListNode(T value, SinglyLinkedListNode<T> nextNode)
        {
          Next = nextNode;
          Value = value;
        }
      }
}