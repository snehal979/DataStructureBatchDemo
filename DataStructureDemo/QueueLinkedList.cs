using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    public class QueueLinkedList
    {
        public Node top;
        /// <summary>
        /// Enqueue -Add
        /// </summary>
        /// <param name="data"></param>
        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (top == null)
            {
                top = newNode;
            }
            else
            {
                Node temp = top;
                while (temp.next !=null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }
        /// <summary>
        /// Dequeue -Delect
        /// </summary>
        public void Dequeue()
        {
            top = top.next;
        }
        /// <summary>
        /// Display
        /// </summary>
        public void Display()
        {
            if (top==null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Node temp = top;
                while (temp!=null)
                {
                    Console.WriteLine(temp.data);
                    temp=temp.next;
                }
            }
        }
    }
}
