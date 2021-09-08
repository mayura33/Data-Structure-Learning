using Datastructure.LinkedList.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.LinkedList
{
    public class DoulbyLinkedList
    {
        Node first;
        Node last;

        public DoulbyLinkedList()
        {
            first = null;
            last = null;
        }
        public static void Execute()
        {
            DoulbyLinkedList linkedList = new DoulbyLinkedList();
            linkedList.InsertFirst(22);
            linkedList.InsertFirst(44);
            linkedList.InsertFirst(66);
            linkedList.InsertLast(11);
            linkedList.InsertLast(33);
            linkedList.InsertLast(55);
            linkedList.DisplayForward();
            linkedList.DisplayBackward();

            linkedList.DeleteFirst();
            linkedList.DeleteLast();

            linkedList.DeleteKey(11);
            linkedList.DisplayForward();

            linkedList.InsertAfter(22, 77);
            linkedList.InsertAfter(33, 88);

            //linkedList.DeleteFirst();
            linkedList.DisplayForward();
        }

        public bool IsEmpty()
        {
            return first == null;
        }

        public void InsertFirst(int data)
        {
            Node newNode = new Node();
            newNode.data = data;

            if (IsEmpty())
            {
                last = newNode;
            }
            else
            {
                first.previous = newNode;
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
                first = newNode;
            }
            else
            {
                last.next = newNode;
                newNode.previous = last;
            }
            last = newNode;
        }

        public Node DeleteFirst()
        {
            Node temp = first;

            if (first.next == null)
            {
                last = null;
            }
            else
            {
                first.next.previous = null;
            }

            first = first.next;
            return temp;
        }

        public Node DeleteLast()
        {
            Node temp = last;
            if (first.next == null)
            {
                first = null;
            }
            else
            {
                last.previous.next = null;
            }
            last = last.previous;
            return temp;
        }

        public bool InsertAfter(int key, int data)
        {
            Node current = first;
            while (current.data != key)
            {
                current = current.next;
                if (current == null)
                {
                    return false;
                }
            }
            Node newNode = new Node();
            newNode.data = data;

            if (current == last)
            {
                current.next = null;
                last = newNode;
            }
            else
            {
                newNode.next = current.next;
                current.next.previous = newNode;
            }

            newNode.previous = current;
            current.next = newNode;
            return true;
        }

        public Node DeleteKey(int key)
        {
            Node current = first;
            while (current.data != key)
            {
                current = current.next;
                if (current == null)
                {
                    return null;
                }
            }

            if (current == first)
            {
                first = current.next;
            }
            else
            {
                current.previous.next = current.next;
            }

            if (current == last)
            {
                last = last.previous;
            }
            else
            {
                current.next.previous = current.previous;
            }
            return current;
        }

        public void DisplayForward()
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

        public void DisplayBackward()
        {
            Console.WriteLine("List (Last---->First)");
            Node current = last;

            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.previous;
            }
            Console.WriteLine();
        }
    }

}


