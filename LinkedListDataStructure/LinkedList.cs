// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedList.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kirti Swaraj"/>
// --------------------------------------------------------------------------------------------------------------------
namespace LinkedListDataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class LinkedList
    {
        public Node head;

        /// <summary>
        /// UC 1 and 3 : Inserts newData at the last or end of linked list
        /// </summary>
        /// <param name="newData">The new data.</param>
        public void InsertAtLast(int newData)
        {
            Node newNode = new Node(newData);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = newNode;
            }
            Console.WriteLine($"Inserted at linked list last :{newNode.data}");
        }

        /// <summary>
        /// Gets the last node.
        /// </summary>
        /// <returns></returns>
        public Node GetLastNode()
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        /// <summary>
        /// UC 2 : Inserts newData at beginning of linked list.
        /// </summary>
        /// <param name="newData">The new data.</param>
        public void InsertAtFront(int newData)
        {
            Node newNode = new Node(newData);
            /// Linking the newly created node to the current head
            newNode.next = this.head;
            /// Updating the current head to newNode so head node changes to newNode
            this.head = newNode;
            Console.WriteLine($"Inserted at linked list beginning :{newNode.data}");
        }
        /// <summary>
        /// UC 4 : Inserts newData between data1 and data2.
        /// </summary>
        /// <param name="data1">The data1.</param>
        /// <param name="data2">The data2.</param>
        /// <param name="newData">The new data.</param>
        public void InsertBetween(int data1, int data2, int newData)
        {
            Node newNode = new Node(newData);
            Node temp1 = this.head;
            Node temp2 = this.head;
            /// Get the position of data1
            while (temp1.data != data1)
                temp1 = temp1.next;
            /// Get the position of data2
            while (temp2.data != data2)
                temp2 = temp2.next;
            /// If the nodes data1 and data2 are not consecutive
            if (temp1.next != temp2 && temp2.next != temp1)
                Console.WriteLine($"There already exists one or more nodes between {data1} and {data2}");
            else
            {
                temp1.next = newNode;
                newNode.next = temp2;
                Console.WriteLine($"New data added successfully between {data1} and {data2}");
            }
        }


        /// <summary>
        /// Displays the contents of linked list.
        /// </summary>
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("The linked list is empty");
            }
            else
            {
                Console.Write("\nLinked list serialized contents: ");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }

                Console.WriteLine("\n");
            }
        }
    }
}
