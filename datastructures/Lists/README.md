# Data Structures and Their Algorithms in C#

This repository holds some implementations (and testing) of data structures and their algorithms in C#

## Lists
### Common Functionality (with Space and Time Complexity)

#### Constructors and Assignment
* `LinkedList<T>()`
  * Default constructor
  * Space Complexity: O(1); Time Complexity: O(1)
* `DeepCopy()`
  * Returns a deep copy list utilizing a copy constructor
  * Space Complexity: O(n); Time Complexity: O(n)

#### Element Access
* `Head`
  * Returns the first element of the list
  * Space Complexity: O(1); Time Complexity: O(1)
* `Tail`
  * Returns the last element of the list
  * Space Complexity: O(1); Time Complexity: O(1) 

#### Insertion and Removal
* `InsertFirst(element)`
  * Add `element` to the first position of the list
  * Space Complexity: O(1); Time Complexity: O(1)
* `InsertLast(element)`
  * Add `element` to the last position of the list
  * Space Complexity: O(1); Time Complexity: O(1)
* `InsertBefore(index, element)`
  * Add `element` direclty before the given Node indicated by `index`
  * Space Complexity: O(1); Time Complexity: O(n)
* `RemoveFirst()`
  * Remove and return the first node of the list
  * Space Complexity: O(1); Time Complexity: O(1)
* `RemoveLast()`
  * Remove and return the last node of the list
  * Space Complexity: O(1); Time Complexity: O(1)
* `Remove(index)`
  * Remove and return the Node at `index`
  * Space Complexity: O(1); Time Complexity: O(n)
* `Remove(element)`
  * Remove all Nodes with `element` as their value
  * Space Complexity: O(1); Time Complexity: O(n)

#### Size
* `Empty()`
* `Count`
#### Iterators

#### Miscellaneous
* `Reverse()`
* `Sort()`
* `Sort(comparison)`
* `Merge(secondList)`
* `ToString()`
### Types
* Singly Linked List (SLL)
* Circular Singly Linked List (CLL)
* Doubly Linked List (DLL)
* Circular Doubly Linked List (CDLL)

## * Priority Queue (Heap Implementation)

## * Binary Tree

## * Graph
