using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListDataStructure;
namespace MSTestForLinkedList
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SearchIntoLinkedList()
        {
            //Arrange
            int expected = 3;
            LinkedList linkedList = new LinkedList();
            linkedList.InsertAtLast(56);
            linkedList.InsertAtLast(30);
            linkedList.InsertAtLast(30);
            linkedList.InsertAtLast(30);
            //Act
            int actual = linkedList.SearchFor(30);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
