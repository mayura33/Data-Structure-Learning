using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure.Basic_DS
{
    //FIFO
    public class QueueDS
    {
        int maxSize;
        int[] queArray;
        int front;
        int rear;
        int currentCount;

        public QueueDS(int size)
        {
            maxSize = size;
            queArray = new int[size];
            front = 0;
            rear = -1;
            currentCount = -1;
        }
        public static void Execute(int size)
        {

            QueueDS myQuue = new QueueDS(size);
            Console.WriteLine("Executing From : " + myQuue.GetType().Name);
            myQuue.Enqueue(100);
            myQuue.Enqueue(200);
            myQuue.Enqueue(300);
            myQuue.Enqueue(400);
            myQuue.Enqueue(500);

            myQuue.Dequeue();
            myQuue.Dequeue();
            myQuue.Enqueue(600);

            myQuue.View();
        }
        public void Enqueue(int num)
        {
            if (rear == maxSize - 1)
            {
                Console.WriteLine("Here Stack is Full so setting top=-1 || Num is : " + num);
                rear = -1;
            }
            rear++;
            queArray[rear] = num;
            currentCount++;
        }

        public int PeakFront()
        {
            return queArray[front];
        }
        public bool IsEmpty()
        {
            return maxSize == currentCount;
        }
        public int Dequeue()
        {
            int temp = queArray[front];
            queArray[front] = 0;
            front++;
            if (front == maxSize)
            {
                front = 0; //So we can utilize again an entire array
            }
            currentCount--;
            return temp;
        }

        public void View()
        {
            Console.Write("[");
            for (int i = 0; i < queArray.Length; i++)
            {
                Console.Write(queArray[i] + " ");
            }
            Console.Write("]");
        }
    }
}

