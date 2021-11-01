using System;
using datastructures.Lists;

namespace datastructures
{
    class Program
    {
        public static void Main(String[] args) {
      var myList = new SinglyLinkedList<int>();
      int myInt = 4;
      myList.Push(myInt);
      //Console.WriteLine(myList.ToString());
      //Console.WriteLine(myList.Count);
      foreach(int value in myList) {
        Console.WriteLine(value);
      }
    }

    public static int CompressedFileSize(int[] fileSizes) 
    {
        MinHeap<int> priorityQueue = new MinHeap<int>();

        foreach (int fileSize in fileSizes) 
        {
            priorityQueue.Insert(fileSize);
        }

        int total = 0;
        int sum = 0;
        while (priorityQueue.Count > 1)
        {
            sum = priorityQueue.Pop() + priorityQueue.Pop();
            total += sum;
            priorityQueue.Insert(sum);
        }

        total += priorityQueue.Pop();

        return total;
    }

    // Implement your solution below.
    // NOTE: Remember to return an Integer array, not an int array.
    public static int[] CommonElements(int[] array1, int[] array2) {
        int ai = 0;
        int bj = 0;
        int ck = 0;
        
        
        int max_size = Math.Max(array1.Length, array2.Length);
        int[] resultInArray = new int[max_size];
        
        while (ai < array1.Length && bj < array2.Length)
        {
            if (array1[ai] < array2[bj]) ai++;
            else if (array1[ai] > array2[bj]) bj++;
            else if (array1[ai] == array2[bj]) {
                resultInArray[ck++] = array1[ai];
                ai++;
                bj++;
            }
            
        }
        
        return resultInArray;
    }
    }
}
