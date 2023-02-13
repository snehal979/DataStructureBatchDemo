using DataStructureDemo;

namespace DataStructure
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Manulally Linked List
            LinkedListClass linkedListClass = new LinkedListClass();
            //AddFirst
            linkedListClass.AddFirst(30);
            linkedListClass.AddFirst(70);
            linkedListClass.AddFirst(56);
            //Display
            linkedListClass.Display();
            //AddLast
            linkedListClass.AddLast(80);
            linkedListClass.AddLast(90);
            linkedListClass.AddLast(20);
            //Display
            Console.WriteLine("----------");
            linkedListClass.Display();
            //Appened
            linkedListClass.Append(32);
            //Display
            Console.WriteLine("----------");
            linkedListClass.Display();
            //Search
            linkedListClass.Search(30);
            //Remove
            linkedListClass.RemoveFirst();
            //Display
            Console.WriteLine("----------");
            linkedListClass.Display();

            StackLinkedList stackLinked = new StackLinkedList();
            stackLinked.push(30);
            stackLinked.push(56);
            stackLinked.push(70);
            stackLinked.DisplayStack();
            stackLinked.Pop();
            stackLinked.DisplayStack();
            stackLinked.Peek();


            QueueLinkedList queueLinkedList = new QueueLinkedList();
            queueLinkedList.Enqueue(30);
            queueLinkedList.Enqueue(50);
            queueLinkedList.Enqueue(70);
            queueLinkedList.Dequeue();
            queueLinkedList.Display();
        }
    }
}