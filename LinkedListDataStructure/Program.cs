﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kirti Swaraj"/>
// --------------------------------------------------------------------------------------------------------------------
namespace LinkedListDataStructure
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.InsertAtLast(56);
            linkedList.Display();
            linkedList.InsertAtLast(30);
            linkedList.Display();
            linkedList.InsertAtLast(70);
            linkedList.Display();
            Console.ReadKey();
        }
    }
}