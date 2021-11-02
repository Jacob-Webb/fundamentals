using System;
using DataStructures.Lists;
using NUnit.Framework;

namespace DataStructuresTests
{
    public class SinglyLinkedListTests
    {
      SinglyLinkedList<int> _testList;
        [SetUp]
        public void Setup()
        {
          _testList = new SinglyLinkedList<int>();
        }

        [Test]
        public void InsertFirst_ListIsEmpty_HeadAndTailAreEqual()
        {
          _testList.InsertFirst(4);

          Assert.AreEqual(_testList.Head, _testList.Tail);
        }

        [Test]
        public void InsertFirst_ListIsNonEmpty_NewValueIsHead()
        {
          _testList.InsertFirst(4);
          _testList.InsertFirst(3);

          Assert.AreEqual(3, _testList.Head.Element);
        }

        [Test]
        public void InsertFirst_ListIsNonEmpty_HeadAndTailUnique()
        {
          _testList.InsertFirst(4);
          _testList.InsertFirst(3);

          Assert.AreNotEqual(_testList.Head, _testList.Tail);
        }

        // [Test]
        // public void MethodToTest_ConditionToTest_ExpectedResult()
        // {
        //   // Arrange
        //   // Act
        //   // Assert
        // }
    }
}