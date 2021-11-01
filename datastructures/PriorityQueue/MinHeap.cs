using System;

public class MinHeap<T> : IHeap<T>
  where T : System.IComparable<T>
{
  // Utilizing a second array _keyPosition allows us to use objects as keys for the heap
  T[] _elements;       
  int _root = 1;

  public int Count { get; set; }

  public MinHeap(int heapSize = 1)
  {
    _elements = new T[heapSize];
    Count = 0; 
  }

  public void Insert(T element)
  {
    if (Count + 1 == _elements.Length) IncreaseSize();
    ++Count;
    _elements[Count] = element;
    HeapifyUp(Count);
  }

  public T Pop()
  {
    return Delete(Peek());
  }

  public int Peek()
  {
    return _root;
  }

  public T Delete(int position)
  {
    // Store element at root
    // Set root to end value
    // Reduce number of elements
    T minElement = _elements[position];

    _elements[position] = _elements[Count]; 
    --Count;
    HeapifyDown(position);

    return minElement;
  }

  /*
  *  Utility functions
  */ 
  private void IncreaseSize()
  {
    T[] largerValueArray = new T[_elements.Length * 2];
    for (int i = 0; i < _elements.Length; ++i) {
      // shallow copy
      largerValueArray[i] = _elements[i];
    }
    _elements = largerValueArray;
  }

  private void HeapifyUp(int position)
  {
    if (position == _root) return;

    int parent = position / 2;
    if (_elements[position].CompareTo(_elements[parent]) < 0) {
      
      Swap(ref _elements[position], ref _elements[parent]);

      HeapifyUp(parent);
    }
  }

  private void HeapifyDown(int position) 
  {
    // if the position is a leaf, return
    if ((position * 2) > Count) return;

    int leftChild = position * 2;
    int rightChild = position * 2 + 1;

    if ((_elements[position].CompareTo(_elements[leftChild]) > 0) 
          || (_elements[position].CompareTo(_elements[rightChild]) > 0)) {
       int minimumChild = MinimumChild(_elements, leftChild, rightChild);

       Swap(ref _elements[position], ref _elements[minimumChild]);
       HeapifyDown(minimumChild);
    }
  }

  private void Swap(ref T a, ref T b) 
  {
    T temp = a;
    a = b;
    b = temp;
  }

  private int MinimumChild(T[] position, int positionA, int positionB) 
  {
    return position[positionA].CompareTo(position[positionB]) < 0 ? positionA : positionB;
  }

}