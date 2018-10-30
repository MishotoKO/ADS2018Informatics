﻿using System;

namespace Circular_Linked_List
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int choice, data, x;

            CircularLinkedList list = new CircularLinkedList();

            list.CreateList();

            while (true)
            {
                Console.WriteLine("1.Display list.");
                Console.WriteLine("2.Insert in an empty list.");
                Console.WriteLine("3.Insert in the beginning of the list.");
                Console.WriteLine("4.Insert at the end of the list.");
                Console.WriteLine("5.Delete first node.");
                Console.WriteLine("6.Delete last node.");
                Console.WriteLine("7.Delete any node.");
                Console.WriteLine("8.Quit.");

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 8)
                    break;

                switch (choice)
                {
                    case 1:
                        list.DisplayList();
                        break;

                    case 2:
                        Console.WriteLine("Enter the element to be insterted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertInEmptyList(data);
                        break;

                    case 3:
                        Console.WriteLine("Enter the element to be inserted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertInBeginning(data);
                        break;

                    case 4:
                        Console.WriteLine("Enter the element to be inserted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtEnd(data);
                        break;

                    case 5:
                        list.DeleteFirstNode();
                        break;

                    case 6:
                        list.DeleteLastNode();
                        break;

                    case 7:
                        Console.WriteLine("Enter the element to be deleted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.DeleteNode(data);
                        break;

                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Exiting");
        }
    }
}