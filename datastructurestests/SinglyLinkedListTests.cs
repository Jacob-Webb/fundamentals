using datastructures.Lists;
using NUnit.Framework;

namespace datastructurestests
{
    public class SinglyLinkedListTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DefaultConstructor_MembersAreDefault()
        {
            var myList = new SinglyLinkedList<int>();
            Assert.AreEqual(null, myList.Head);
            Assert.AreEqual(null, myList.Tail);
            Assert.AreEqual(0, myList.Count);
        }
    }
}