using System;
using DataStructures.Lists;
using NUnit.Framework;

namespace DataStructuresTests
{
    public class SinglyLinkedListTests
    {
      SinglyLinkedList<string> _testList;

      [SetUp]
      public void Setup()
      {
        _testList = new SinglyLinkedList<string>();
      }

      [Test]
      public void InsertFirst_ListIsEmpty_HeadAndTailAreEqual()
      {
        _testList.InsertFirst("1");

        Assert.AreEqual(_testList.Head, _testList.Tail);
      }

      [Test]
      public void InsertFirst_ListIsNonEmpty_HeadAssignedToNewValue()
      {
        _testList.InsertFirst("1");
        _testList.InsertFirst("2");

        Assert.AreEqual("2", _testList.Head.Element);
        Assert.AreNotEqual(_testList.Head, _testList.Tail);
      }
      [Test]
      public void InsertLast_ListIsEmpty_HeadAndTailAreEqual()
      {
        _testList.InsertLast("1");

        Assert.AreEqual(_testList.Head, _testList.Tail);
      }
      [Test]
      public void InsertLast_ListIsNonEmpty_TailAssignedToNewValue()
      {
        _testList.InsertLast("1");
        _testList.InsertLast("2");

        Assert.AreEqual("2", _testList.Tail.Element);
        Assert.AreNotEqual(_testList.Head, _testList.Tail);
        Assert.AreEqual(2, _testList.Count);
      }
      [Test]
      public void InsertBefore_OnValidIndex_InsertsNewNodeBeforeIndex()
      {
        _testList.InsertBefore(0, "3");
        _testList.InsertBefore(0, "1");
        _testList.InsertBefore(1, "2");

        Assert.AreEqual("2", _testList.Head.Next.Element);
        Assert.AreEqual(3, _testList.Count);
      }
      [Test]
      public void InsertBefore_OnInvalidIndex_ThrowsArgumentOutOfRangeException()
      {
        //_testList.InsertBefore(0, "2");
        Assert.Throws<ArgumentOutOfRangeException>(
          () => _testList.InsertBefore(-1, "3"));
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