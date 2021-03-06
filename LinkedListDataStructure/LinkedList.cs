﻿// --------------------------------------------------------------------------------------------------------------------
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
public class LinkedList
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
        /// UC 4and 8  : Inserts newData between data1 and data2.
        /// </summary>
        /// <param name="data1">The data1.</param>
        /// <param name="data2">The data2.</param>
        /// <param name="newData">The new data.</param>
        public int InsertBetween(int data1, int data2, int newData)
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
            {
                Console.WriteLine($"There already exists one or more nodes between {data1} and {data2}");
                return 0;
            }
            else
            {
                temp1.next = newNode;
                newNode.next = temp2;
                Console.WriteLine($"New data added successfully between {data1} and {data2}");
                return newData;
            }
        }
        /// <summary>
        /// UC 5 : Removes the first node of the linked list
        /// </summary>
        public void RemoveFirstNode()
        {
            if (this.head == null)
                Console.WriteLine("The linked list is empty");
            else
            {
                this.head = this.head.next;
                Console.WriteLine("First node removed successfully");
            }
        }
        /// <summary>
        /// UC 6 : Removes the last node of the linked list.
        /// </summary>
        public void RemoveLastNode()
        {
            /// Checks if the linked list is empty
            if (this.head == null)
                Console.WriteLine("The linked list is empty");
            /// Checks if the linked list has only one node
            else if (this.head.next == null)
            {
                this.head = null;
                Console.WriteLine("Last node removed successfully");
            }
            else
            {
                Node temp = this.head;
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                /// Assign next of 2nd last node to null to remove last node
                temp.next = null;
                Console.WriteLine("Last node removed successfully");
            }
        }
        /// <summary>
        /// UC 7 : Searches for the data in the list and returns its count
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        public int SearchFor(int data)
        {
            int count = 0;
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == data)
                    count++;
                temp = temp.next;
            }
            if (count == 0)
                Console.WriteLine("Element not found");
            else
                Console.WriteLine($"Element {data} is present and its count = {count}");
            return count;
        }
        /// <summary>
        /// UC 9 : Removes the node at which the entered data is present.
        /// </summary>
        /// <param name="data">The data.</param>
        public void RemoveNode(int data)
        {
            Node temp = this.head;
            if (this.head == null)
                Console.WriteLine("The linked list is empty");
            /// Checks if the linked list has only one node
            else if (this.head.data == data)
            {
                this.head = null;
                Console.WriteLine("Node removed successfully");
            }
            else
            {
                /// Finding the node at which the data is present
                while (temp.next.data != data)
                {
                    temp = temp.next;
                }
                Console.WriteLine("Node removed successfuly");
                temp.next = temp.next.next;
            }
            Console.WriteLine("Size of the linked list = " + GetSize());
        }

        /// <summary>
        /// Gets the size of the linked list.
        /// </summary>
        /// <returns></returns>
        public int GetSize()
        {
            int count = 0;
            Node temp = this.head;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
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
