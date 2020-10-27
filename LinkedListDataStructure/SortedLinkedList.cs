// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kirti Swaraj"/>
// --------------------------------------------------------------------------------------------------------------------

namespace LinkedListDataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class SortedLinkedList
    {
        public Node head;

        /// <summary>
        /// UC 10 : Adds the elements in sorted order into the linked list.
        /// </summary>
        /// <param name="newData">The new data.</param>
        public void AddElementsInSortedOrder(int newData)
        {
            Node newNode = new Node(newData);
            /// If the linked list is empty, add the node at the beginning
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                ///If the value of the node to be inserted is 
                ///smaller than the value of the head node,
                ///then insert the node at the start and make it head.
                if (newNode.data < this.head.data)
                {
                    newNode.next = this.head;
                    this.head = newNode;
                }
                else
                {
                    Node temp = this.head;
                    /// Find the appropriate temp position next to which the node will be inserted
                    while (temp.next != null && temp.next.data < newData)
                    {
                        temp = temp.next;
                    }
                    /// If it is not the last node
                    if (temp.next != null)
                    {
                        newNode.next = temp.next;
                        temp.next = newNode;
                    }
                    /// If the node to be inserted is next to last node
                    else
                    {
                        temp.next = newNode;
                        newNode.next = null;
                    }
                }
            }
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("\nDisplay:The linked list is empty");
            }
            else
            {
                Console.Write("\nDisplay:Linked list serialized contents: ");
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
