using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Basic_DS
{
    //LIFO
    public class StackDS
    {
        int maxSize;
        int[] stackArray;
        int top;

        public StackDS(int size)
        {
            maxSize = size;
            stackArray = new int[size];
            top = -1;
        }

        public static void Execute(int size)
        {
            StackDS myStack = new StackDS(size);
            Console.WriteLine("Executing From : " + myStack.GetType().Name);
            myStack.Pop();
            myStack.Push(100);
            myStack.Push(200);
            myStack.Push(300);
            myStack.Push(400);
            myStack.Push(500);
            myStack.Push(600);
            myStack.Push(700);
            myStack.View();
        }

        public void Push(int num)
        {
            if (IsFull())
            {
                Console.WriteLine("Here Stack is Full so setting top=-1 || Num is : " + num);
                top = -1;
            }

            top++;
            stackArray[top] = num;

        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is emptry, Operation aborted");
                return -1;
            }

            int old_top = top;
            top--;
            return stackArray[old_top];
        }

        public int Peak()
        {
            return stackArray[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == (maxSize - 1);
        }

        public void View()
        {
            Console.Write("[");
            for (int i = 0; i < stackArray.Length; i++)
            {
                Console.Write(stackArray[i] + " ");
            }
            Console.Write("]");
        }
    }
}
