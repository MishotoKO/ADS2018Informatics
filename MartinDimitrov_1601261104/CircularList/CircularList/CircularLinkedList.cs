﻿using System;
namespace Circular_Linked_List
{
    public class CircularLinkedList
    {
        private Node last;

        public CircularLinkedList()
        {
            last = null;
        }

        public void DisplayList()
        {
            if (last == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            Node p = last.link;
            do
            {
                Console.Write("\n" +p.info + " ");
                p = p.link;
            } while (p != last.link);

            Console.WriteLine();
        }

        public void InsertInBeginning(int data)
        {
            Node temp = new Node(data);
            temp.link = last.link;
            last.link = temp;
        }

        public void InsertInEmptyList(int data)
        {
            Node temp = new Node(data);
            last = temp;
            last.link = last;
        }

        public void InsertAtEnd(int data)
        {
            Node temp = new Node(data);
            temp.link = last.link;
            last.link = temp;
            last = temp;
        }

        public void CreateList()
        {
            int i, n, data;

            Console.Write("Enter the number of nodes: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;
            Console.Write("Enter the element to be inserted: ");
            data = Convert.ToInt32(Console.ReadLine());
            InsertInEmptyList(data);

            for (i = 2; i <= n; i++)
            {
                Console.Write("Enter the element to be inserted: ");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }
        }

        public void DeleteFirstNode()
        {
            // if list is empty
            if (last == null)
                return;
            // if list has one node
            if (last.link == last)
            {
                last = null;
                return;
            }

            last.link = last.link.link;
        }

        public void DeleteLastNode()
        {
            // if list is empty
            if (last == null)
                return;
            // if list has one node
            if (last.link == last)
            {
                last = null;
                return;
            }

            Node p = last.link;
            while (p.link != last)
                p = p.link;
            p.link = last.link;
            last = p;
        }

        public void DeleteNode(int x)
        {
            // list is empty
            if (last == null)
                return;
            // delete the only node
            if (last.link == last && last.info == x)
            {
                last = null;
                return;
            }
            // delete the first node
            if (last.link.info == x)
            {
                last.link = last.link.link;
                return;
            }
            // delete a node in between the list
            Node p = last.link;
            while (p.link != last.link)
            {
                if (p.link.info == x)
                    break;
                p = p.link;
            }

            if (p.link == last.link)
                Console.WriteLine(x + " not found in the list.");
            else
            {
                p.link = p.link.link;
                if (last.info == x)
                    last = p;
            }
        }
    }
}
