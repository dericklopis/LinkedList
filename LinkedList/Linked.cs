using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Linkedlist
    {
        public Node head;

        public void AddLast(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next!= null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} Inserted in linked list ", node.data);
            Console.ReadLine();
        }
        public void AddFirst(int data)      //AddFirst UC2
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
            Console.WriteLine($"{newNode.data} is added into the list.");
            Console.ReadLine();
        }
        public void Append(int data)
        {
            AddLast(data);
        }
        public void InsertBetweenNodes(int insertAfter, int data, int insertBefore)       //InsertBetweenNodes() UC4.
        {
            Node newNode = new Node(data);
            bool isFound = false;
            Node temp = head;
            if (temp == null)
                Console.WriteLine("Linked List is empty");
            else
            {
                while (temp != null)
                {
                    if (temp.data == insertAfter && temp.next.data == insertBefore)
                    {
                        //Console.WriteLine($"{temp.data} node is present");
                        newNode.next = temp.next;
                        temp.next = newNode;
                        Console.WriteLine($"{newNode.data} insertion done between {temp.data} and {newNode.next.data}.");
                        isFound = true;
                        break;
                    }
                    temp = temp.next;
                }
            }
            if (!isFound)
                Console.WriteLine($"{data} node is not present.");
                Console.ReadLine();
        }
        public void RemoveFirst()      //AddFirst UC5 
        {
            int deletedNode = head.data;
            head = head.next;
            Console.WriteLine($"First node {deletedNode} has been removed.");
            Console.ReadLine();
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp==null)
            {
                Console.WriteLine("Linkedlist Is Empty");
                Console.ReadLine();
                return;
            }
            else
            {
                while (temp!=null)
                {
                    Console.WriteLine(temp.data+ " ");
                    Console.ReadLine();
                    temp = temp.next;
                }
            }
        }
    }
}
