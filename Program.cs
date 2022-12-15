using System;

namespace DataStructure
{
    class Program
    {
        public static void Main(string[] args)
        { 
            Console.WriteLine("Welcome To the Data structure program using Linked List");

            /*LinkedList linkedList2 = new LinkedList();
            linkedList2.Append(56);
            linkedList2.Append(30);
            linkedList2.Append(70);
            linkedList2.Display();



            LinkedList linkedList3 = new LinkedList();
            linkedList3.Add(56);
            linkedList3.Add(70);
            //linkedList.Display();

            linkedList3.InsertAtParticularPoistion(2, 30);
            linkedList3.Display();



            LinkedList remove = new LinkedList();
            remove.Add(56);
            remove.Add(30);
            remove.Add(70);
            remove.Display();
            Console.WriteLine("First element is poped out from linked list = " + remove.removeFirstNode().data);
            remove.Display();

            LinkedList rm = new LinkedList();
            rm.Add(56);
            rm.Add(30);
            rm.Add(70);
            rm.Display();
            Console.WriteLine("last element is poped out from linked list = " + rm.removeLastNode().data);
            rm.Display();
            
            Console.WriteLine("UC7");

            LinkedList sn = new LinkedList();
            sn.Add(56);
            sn.Add(30);
            sn.Add(70);
            sn.Display();
            Console.WriteLine("Serach node: " + sn.Search(30).data);
            

            Console.WriteLine("\n UC8");
            LinkedList obj = new LinkedList();
            obj.Add(56);
            obj.Add(30);
            obj.Add(70);
            //linkedList.Display();

            obj.AddInBet2(obj.head.next, 40);
            obj.Display();
            

            Console.WriteLine("\n UC9");
            LinkedList obj1 = new LinkedList();
            obj1.Add(56);
            obj1.Add(30);
            obj1.Add(40);
            obj1.Add(70);
            obj1.Display();
            obj1.deleteNode(40);
            obj1.Display();
            Console.WriteLine("size is: " + obj1.size());*/



            Console.WriteLine("\n UC10");
            SortedLinkedList sort = new SortedLinkedList();
            sort.Add(56);
            sort.Add(30);
            sort.Add(40);
            sort.Add(70);
            sort.Display();
        }

    }
}