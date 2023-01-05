using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList");

            Linked objLinkedList = new Linked();
            objLinkedList.Add(56);
            objLinkedList.Add(30);
            objLinkedList.Add(70);
            objLinkedList.Display();

            Console.ReadLine();
        }
    }
}
