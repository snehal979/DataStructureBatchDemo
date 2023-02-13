using DataStructureDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    public class LinkedListClass
    {
        public Node head;
        /// <summary>
        /// AddLast 
        /// </summary>
        /// <param name="data"></param>
        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.next !=null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }
      /// <summary>
      /// AddFirst
      /// </summary>
      /// <param name="data"></param>
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head =newNode;
        }
        /// <summary>
        /// Append data
        /// </summary>
        /// <param name="data"></param>
        public void Append(int data)
        {
            AddLast(data);
        }
        /// <summary>
        /// RemoveFirst
        /// </summary>
        public void RemoveFirst()
        {
            if (head == null)
            {
                Console.WriteLine("the list is empty");
            }
            else
            {
                Console.WriteLine("remove"+head.data);
                head =head.next;
            }
        }
        /// <summary>
        /// Search
        /// </summary>
        /// <param name="data"></param>
        public void Search(int data)
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                while (temp!=null)
                {
                    if (temp.data==data)
                    {
                        Console.WriteLine("Data is present "+temp.data);
                        break;
                    }
                    temp =temp.next;
                }
            }
        }
        /// <summary>
        /// Display Data
        /// </summary>
        public void Display()
        {
            if (head==null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            else
            {
                Node temp = head;
                while (temp!=null)
                {
                    Console.WriteLine(temp.data);
                    temp=temp.next;
                }
            }
        }
    }
}

