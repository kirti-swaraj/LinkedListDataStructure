using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListDataStructure;
namespace MSTestForLinkedList
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// UC 7 : Searches the into linked list.
        /// </summary>
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
        /// <summary>
        /// UC 8 : Inserts an element betweent two elements.
        /// </summary>
        [TestMethod]
        public void InsertBetweentElements()
        {
            //Arrange
            int expected = 40;
            LinkedList linkedList = new LinkedList();
            linkedList.InsertAtLast(56);
            linkedList.InsertAtLast(30);
            linkedList.InsertAtLast(70);
            //Act
            int actual = linkedList.InsertBetween(30, 70, 40);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
