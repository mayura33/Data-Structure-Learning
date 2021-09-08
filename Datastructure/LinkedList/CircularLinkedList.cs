using Datastructure.LinkedList.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.LinkedList
{
    class CircularLinkedList
    {
        Node first;
        Node last;

        public CircularLinkedList()
        {
            first = null;
            last = null;
        }
        public static void Execute()
        {
            CircularLinkedList linkedList = new CircularLinkedList();
            linkedList.InsertFirst(100);
            linkedList.InsertFirst(200);
            linkedList.InsertFirst(300);
            linkedList.InsertFirst(400);
            linkedList.InsertLast(99999);
            //linkedList.DeleteFirst();
            linkedList.DisplayList();
        }

        public void InsertFirst(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            if (IsEmpty())
            {
                last = newNode;
            }

            newNode.next = first;
            first = newNode;
        }
        public void InsertLast(int data)
        {
            Node newNode = new Node();
            newNode.data = data;

            if (IsEmpty())
            {
                last = newNode;
            }
            else
            {
                last.next = newNode;
                last = newNode;
            }
        }

        public int DeleteFirst()
        {
            int temp = first.data;

            if (first.next == null)
            {
                last = null;
            }

            first = first.next;
            return temp;
        }

        private bool IsEmpty()
        {
            return first == null;
        }

        public void DisplayList()
        {
            Console.WriteLine("List (First---->Last)");
            Node current = first;

            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }

    }
}
