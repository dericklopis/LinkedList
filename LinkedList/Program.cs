using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome To Linked List Program ");
            Console.WriteLine("===============================");
            Console.WriteLine("Choose a option from below\n" +
                "\n1: To Creating a linked list \n" +
                "2: To AddFirst in a linked list \n" +
                "3: To Append in a linked list \n");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Linkedlist linkedList = new Linkedlist();
                    linkedList.AddLast(56);
                    linkedList.AddLast(30);
                    linkedList.AddLast(70);
                    linkedList.Display();
                    break;
                case 2:
                    Linkedlist linkedlist = new Linkedlist();
                    linkedlist.AddFirst(70);
                    linkedlist.AddFirst(30);
                    linkedlist.AddFirst(56);
                    linkedlist.Display();
                    break;
                case 3:
                    Linkedlist linkedlist1 = new Linkedlist();
                    linkedlist1.Append(70);
                    linkedlist1.Append(30);
                    linkedlist1.Append(50);
                    break;
                default:
                    Console.WriteLine("Choose a Valid Option");
                    Console.ReadLine();
                    break;
            }
        }
    }
}

