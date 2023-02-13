using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    public class StackLinkedList
    {
        public Node top;
        /// <summary>
        /// Push-Add Data
        /// </summary>
        /// <param name="data"></param>
        public void push(int data)
        {
            Node newNode = new Node(data);
            if (top==null)
            {
                top=newNode;
                Console.WriteLine("Adding Element"+top.data);
            }
            else
            {
                newNode.next=top;
                top=newNode;
                Console.WriteLine("Adding Element"+top.data);
            }
        }
        /// <summary>
        /// Peek-Top element
        /// </summary>
        public void Peek()
        {
            Console.WriteLine("Top of element :" +top.data);
        }
        /// <summary>
        /// Pop - delect
        /// </summary>
        public void Pop()
        {
            top = top.next;
        }
        /// <summary>
        /// IsEmpty 
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            while (top!=null)
            {
                Peek();
                Pop();
            }
            return true;
        }
        /// <summary>
        /// Display
        /// </summary>
        public void DisplayStack()
        {
            if (top==null)
            {
                Console.WriteLine("No element are present");
            }
            else
            {
                Node temp = top;
                while (temp!=null)
                {
                    Console.WriteLine("stack element"+temp.data);
                    temp =temp.next;
                }
            }
        }
    }
}
