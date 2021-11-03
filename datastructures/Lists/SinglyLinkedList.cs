using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace DataStructures.Lists
{
  public class SinglyLinkedList<T> : IEnumerable<T>, IDeepCloneable<SinglyLinkedList<T>>
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
    protected SinglyLinkedList(SinglyLinkedList<T> listToCopy) : this()
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
    public void InsertFirst(T element)
    {
      InsertBefore(0, element);
      //Head = new Node<T>(element, Head);
      // ++Count;
      // if(Count == 1) Tail = Head;
    }
    public void InsertLast(T element)
    {
      if (Tail == null)
      {
        Head = Tail = new Node<T>(element, Head);
      } else {
        Tail.Next = new Node<T>(element, null);
        Tail = Tail.Next;
      }
      Count++;
    }
    public void InsertBefore(int index, T element)
    {
      if(IsNull(element)) 
      {
        throw new ArgumentNullException($"{nameof(element)} must be non-null");
      }
      if (index < 0) {
        throw new ArgumentOutOfRangeException($"{nameof(index)} must be a positive integer");
      }
      if (index > Count) 
      {
        throw new ArgumentOutOfRangeException($"{nameof(index)} must be less than SinglyLinkedList.Count");
      }

      if (index == 0)            // Add new Node as Head
      {
        Head = new Node<T>(element, Head);
        if(Count == 0) Tail = Head;
      } else {                   // Add new Node before Node at position
        var walkingNode = Head;
        for (int i = 0; i < index - 1; ++i) {
          walkingNode = walkingNode.Next;
        }
        var newNode = new Node<T>(element, walkingNode.Next);
        walkingNode.Next = newNode;
      }

      ++Count;
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


    public SinglyLinkedList<T> DeepClone()
    {
      var newList = new SinglyLinkedList<T>(this);
      //newList.Head = new Node<T>(this.Head.Element, null);
      return newList;
    }

    object IDeepCloneable.DeepClone()
    {
      return this.DeepClone();
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
    private bool IsNull<V>(V item)
    {
      return ((default(V) == null) && (item == null));
    }
  }
}