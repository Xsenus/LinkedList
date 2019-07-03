using LinkedList.Model;
using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CircularLinkedList:");

            var circularList = new CircularLinkedList<int>();
            circularList.Add(1);
            circularList.Add(2);
            circularList.Add(3);
            circularList.Add(4);
            circularList.Add(5);

            foreach (var item in circularList)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\nCircularLinkedList -> Delete");

            circularList.Delete(3);

            foreach (var item in circularList)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\n\nDuplexLinkedList:");

            var duplexList = new DuplexLinkedList<int>();
            duplexList.Add(1);
            duplexList.Add(2);
            duplexList.Add(3);
            duplexList.Add(4);
            duplexList.Add(5);

            foreach (var item in duplexList)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\nDuplexLinkedList -> Delete:");

            duplexList.Delete(3);

            foreach (var item in duplexList)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\nDuplexLinkedList -> Reverse:");

            var reverseDuplexList = duplexList.Reverse();

            foreach (var item in reverseDuplexList)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\n\nLinkedList:");

            var list = new Model.LinkedList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\nLinkedList -> Delete:");

            list.Delelete(3);
            list.Delelete(1);
            list.Delelete(7);

            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\nLinkedList -> AppendHead:");

            list.AppendHead(7);

            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\nLinkedList -> InsertAfter:");

            list.InsertAfter(4, 8);

            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }
    }
}
