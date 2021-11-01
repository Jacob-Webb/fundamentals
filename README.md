# Data Structures and Their Algorithms in C#

This repository holds some implementations (and testing) of data structures and their algorithms in C#

## Lists
---
### Common Functionality (with Space and Time Complexity)
#### Constructors and Assignment
* `LinkedList<T>()`
  * Default constructor
  * Space Complexity: O(1); Time Complexity: O(1)
* `LinkedList<T>(listToCopy)`
  * Copy constructor
  * Space Complexity: O(n): Time Complexity: O(n)
* `newList = oldList`
  * Assignment operator
  * Space Complexity: ?; Time Complexity: ?
#### Element Access
* `Front()`
  * Returns the first element of the list
  * Space Complexity: O(1); Time Complexity: O(1)
* `Last()`
  * Returns the last element of the list
  * Space Complexity: O(1); Time Complexity: ? 
#### Insertion and Removal
* `Push(element)`
  * Add `element` to the first position of the list
  * Space Complexity: O(1); Time Complexity: O(1)
* `Append(element)`
* `Insert(node, element)`
* `PopFront()`
  * Remove and return the first node of the list
  * Space Complexity: O(1); Time Complexity: O(1)
* `PopBack()`
* `Remove(node)`
* `Remove(element)`
#### Size
* `Empty()`
* `Count`
#### Iterators

#### Miscellaneous
* `Reverse()`
* `Sort()`
* `Sort(comparison)`
* `Merge(secondList)`
### Types
* Singly Linked List (SLL)
* Circular Singly Linked List (CLL)
* Doubly Linked List (DLL)
* Circular Doubly Linked List (CDLL)

## * Priority Queue (Heap Implementation)

## * Binary Tree

## * Graph
