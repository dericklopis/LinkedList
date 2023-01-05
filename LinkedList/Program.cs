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
                "3: To Append in a linked list \n" +
                "4: To Insert Between in a linked list \n" +
                "5: To Removing First Element in a linked list \n" +
                "6: To Removing Last Element in a linked list \n" +
                "7: To Search Node in a linked list \n" +
                "8: To Insert An Element After in a linked list \n" +
                "9: To Deleting An Element From Between in a linked list \n");
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
                case 4:
                    Linkedlist linkedlist2 = new Linkedlist();
                    linkedlist2.AddFirst(56);
                    linkedlist2.AddLast(70);
                    linkedlist2.InsertBetweenNodes(56, 30, 70);
                    break;
                case 5:
                    Linkedlist linkedlist3 = new Linkedlist();
                    linkedlist3.AddFirst(56);
                    linkedlist3.AddLast(30);
                    linkedlist3.AddLast(70);
                    linkedlist3.RemoveFirst();
                    linkedlist3.Display();
                    break;
                case 6:
                    Linkedlist linkedlist4 = new Linkedlist();
                    linkedlist4.AddFirst(56);
                    linkedlist4.AddLast(30);
                    linkedlist4.AddLast(70);
                    linkedlist4.RemoveLast();
                    linkedlist4.Display();
                    break;
                case 7:
                    Linkedlist linkedlist5 = new Linkedlist();
                    linkedlist5.AddFirst(56);
                    linkedlist5.AddLast(30);
                    linkedlist5.AddLast(70);
                    linkedlist5.SearchNode(30);
                    break;
                case 8:
                    Linkedlist linkedlist6 = new Linkedlist();
                    linkedlist6.AddFirst(56);
                    linkedlist6.AddLast(30);
                    linkedlist6.AddLast(70);
                    linkedlist6.InsertAfter(30, 40);
                    linkedlist6.Display();
                    break;
                case 9:
                    Linkedlist linkedlist7 = new Linkedlist();
                    linkedlist7.AddLast(56);
                    linkedlist7.AddLast(30);
                    linkedlist7.AddLast(40);
                    linkedlist7.AddLast(70);
                    linkedlist7.DeleteFromMiddle(40);
                    linkedlist7.Display();
                    break;
                default:
                    Console.WriteLine("Choose a Valid Option");
                    Console.ReadLine();
                    break;
            }
        }
    }
}

