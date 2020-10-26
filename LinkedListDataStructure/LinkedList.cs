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
                Console.Write("Linked list serialized contents: ");
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
