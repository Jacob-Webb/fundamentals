using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructures.Lists
{
    public class SinglyLinkedList<T> : IEnumerable<T>
    {
      public Node<T> Head { get; private set; }
      public Node<T> Tail { get; private set; }
      public long Count { get; private set; }

      public SinglyLinkedList()
      {
        Head = null;
        Tail = null; 
        Count = 0;
      }
      public SinglyLinkedList(SinglyLinkedList<T> listToCopy) : this()
      {
        if (IsNull(listToCopy)) 
        {
          throw new ArgumentNullException($"Singularly Linked List copy constructor cannot take null argument");
        }
        var walkingNode = listToCopy.Head;
        var newListNode = new Node<T>(walkingNode.Element, null);
        Head = newListNode;

        while(walkingNode.Next != null)
        {
          newListNode.Next = new Node<T>(walkingNode.Next.Element, null);
          walkingNode = walkingNode.Next;
          newListNode = newListNode.Next;
          ++Count;
        }

        Tail = newListNode;
      }
      public bool Push(T element)
      {
        Head = new Node<T>(element, Head);
        ++Count;
        return true;
      }
      public bool Insert(int position, T element)
      {
        if(IsNull(element) || IsNull(position)) 
        {
          throw new ArgumentNullException($"Argument {element} and {position} must both be non-null");
        }
        if (position < 0) {
          throw new ArgumentOutOfRangeException($"Position {position} must be a positive integer");
        }
        if (position > Count) 
        {
          throw new ArgumentOutOfRangeException($"Position {position} must be less than SinglyLinkedList.Count");
        }

        var newNode = new Node<T>(element);
        if (position == 0) // Add new Node as Head
        {
          newNode.Next = Head;
          Head = newNode;
        } else if (position == Count) // Add new Node as Tail
        {

        } else // Add new Node before Node at position
        {

        }


        return true;
        
      }
      
      public override string ToString()
      {
        StringBuilder sb = new StringBuilder();
        Node<T> walking = Head;
        while(walking != null)
        {
          sb.Append(walking.Element);
          walking = walking.Next;
        }
        return sb.ToString();
      }

      private bool IsNull<V>(V item)
      {
        return ((default(V) == null) && (item == null));
      }

    public IEnumerator<T> GetEnumerator()
    {
      var walkingNode = Head;
      while (walkingNode != null)
      {
        yield return walkingNode.Element;
        walkingNode = walkingNode.Next;
      }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }
  }
}