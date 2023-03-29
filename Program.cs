using System.Collections.Generic;

namespace LinkedListProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            UC_1SimpleLinkedList num = new UC_1SimpleLinkedList();
            num.Addlast(56);
            num.Addlast(30);
            num.Addlast(70);
            num.Display();
            Console.ReadLine();
        }
    }
}