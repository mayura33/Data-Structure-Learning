using Datastructure.LinkedList.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.LinkedList
{
    public class SinglyLinkedList
    {
        Node first;
        public static void Execute()
        {
            SinglyLinkedList linkedList = new SinglyLinkedList();
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
            newNode.next = first;
            first = newNode;
        }
        public void InsertLast(int data)
        {
            Node current = first;

            while (current.next != null)
            {
                current = current.next;
            }

            //We reached at last Element
            Node newNode = new Node();
            newNode.data = data;
            current.next = newNode;
        }
        public Node DeleteFirst()
        {
            Node temp = first;
            first = first.next;
            return temp;
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
