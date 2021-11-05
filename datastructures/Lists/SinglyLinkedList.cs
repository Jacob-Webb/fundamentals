using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace DataStructures.Lists
{
  public class SinglyLinkedList<T> : ILinkedList<T>, IEnumerable<T>, IDeepCloneable<SinglyLinkedList<T>>
  {
    public ILinkedListNode<T> Head { get; private set; }
    public ILinkedListNode<T> Tail { get; private set; }
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
      var walkingNode = (SinglyLinkedListNode<T>)listToCopy.Head;
      var newListNode = new SinglyLinkedListNode<T>(walkingNode.Value, null);
      Head = newListNode;

      while(walkingNode.Next != null)
      {
        newListNode.Next = new SinglyLinkedListNode<T>(walkingNode.Next.Value, null);
        walkingNode = (SinglyLinkedListNode<T>)walkingNode.Next;
        newListNode = (SinglyLinkedListNode<T>)newListNode.Next;
        ++Count;
      }

      Tail = newListNode;
    }
    public void InsertFirst(T value)
    {
      InsertBefore(0, value);
      //Head = new SinglyLinkedListNode<T>(element, Head);
      // ++Count;
      // if(Count == 1) Tail = Head;
    }
    public void InsertLast(T value)
    {
      if (Tail == null)
      {
        Head = Tail = new SinglyLinkedListNode<T>(value, Head);
      } else {
        Tail.Next = new SinglyLinkedListNode<T>(value, null);
        Tail = Tail.Next;
      }
      Count++;
    }
    public void InsertBefore(int index, T value)
    {
      if(IsNull(value)) 
      {
        throw new ArgumentNullException($"{nameof(value)} must be non-null");
      }
      if (index < 0) {
        throw new ArgumentOutOfRangeException($"{nameof(index)} must be a positive integer");
      }
      if (index > Count) 
      {
        throw new ArgumentOutOfRangeException($"{nameof(index)} must be less than SinglyLinkedList.Count");
      }

      if (index == 0)            // Add new SinglyLinkedListNode as Head
      {
        Head = new SinglyLinkedListNode<T>(value, Head);
        if(Count == 0) Tail = Head;
      } else {                   // Add new Node before Node at position
        var walkingNode = Head;
        for (int i = 0; i < index - 1; ++i) {
          walkingNode = walkingNode.Next;
        }
        var newNode = new SinglyLinkedListNode<T>(value, walkingNode.Next);
        walkingNode.Next = newNode;
      }

      ++Count;
    }
    
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      SinglyLinkedListNode<T> walking = Head;
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
      //newList.Head = new SinglyLinkedListNode<T>(this.Head.Element, null);
      return newList;
    }

    object IDeepCloneable.DeepClone()
    {
      return this.DeepClone();
    }

    public IEnumerator<T> GetEnumerator()
    {
      SinglyLinkedListNode<T> walkingNode = Head;
      while (walkingNode != null)
      {
        yield return walkingNode.Value;
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