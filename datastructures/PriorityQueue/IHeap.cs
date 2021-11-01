using System;

public interface IHeap<T>
{
  /*
  * Inserts the item v into heap H. 
  * If the heap has n elements, runs in O(log n) time. 
  */
  void Insert(T element);

  /*
  * Identifies and deletes the element with priority from a heap. 
  * Runs in O(log n) time.
  */
  T Pop();

  /*
  * Identifies the minimum element in the heap H, but does not remove it.
  * Runs in O(1) time
  */
  int Peek();

  /* 
  * Returns and deletes the element in heap position i. 
  * Runs in O(log n) for heaps with n elements
  */
  T Delete(int position);
}