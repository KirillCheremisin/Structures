using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //CheckLinkedList();
            //CheckDoublyLinkedList();
            //CheckStack();
            CheckNodeStack();
        }

        private static void CheckNodeStack()
        {
            NodeStack<string> nameList = new NodeStack<string>();
            Console.WriteLine("Is empty: {0}",nameList.IsEmpty);
            nameList.Push("Tom");
            nameList.Push("Alice");
            nameList.Push("Bob");
            nameList.Push("Kate");

            Console.WriteLine();
            Console.WriteLine("Is empty: {0}", nameList.IsEmpty);
            Console.WriteLine("Name list:");
            foreach (var name in nameList)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
            Console.WriteLine("Count is {0}",nameList.Count);

            Console.WriteLine();
            Console.WriteLine("Peeked item is: {0}", nameList.Peek());

            Console.WriteLine();
            Console.WriteLine("Popped item is: {0}", nameList.Pop());

            Console.WriteLine();
            Console.WriteLine("Name list:");
            foreach (var name in nameList)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
            Console.WriteLine("Count is {0}", nameList.Count);

            _ = Console.ReadLine();
        }

        public static void CheckDoublyLinkedList()
        {
            DoublyLinkedList<string> nameList = new DoublyLinkedList<string>();
            nameList.Add("Tom");
            nameList.Add("Kirill");
            nameList.Add("Maria");
            nameList.Add("Ivan");

            Console.WriteLine("Write initial name list");
            foreach (var name in nameList)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("");
            Console.WriteLine("Write name list back direction");
            foreach(var name in nameList.BackEnumerator())
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("");
            Console.WriteLine("Remove Kirill and write name list");
            nameList.Remove("Kirill");
            foreach (var name in nameList)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("");
            Console.WriteLine("Remove Tom and write name list");
            nameList.Remove("Tom");
            foreach (var name in nameList)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("");
            Console.WriteLine("Check if Tom exist");
            bool isPresent = nameList.Contains("Tom");
            Console.WriteLine(isPresent ? "Tom Yes" : "Tom No");

            Console.WriteLine("");
            Console.WriteLine("Check if Ivan exist");
            isPresent = nameList.Contains("Ivan");
            Console.WriteLine(isPresent ? "Ivan Yes" : "Ivan No");

            Console.WriteLine("");
            Console.WriteLine("Append Artem");
            Console.WriteLine("Check if Artem exist");
            nameList.AddFirst("Artem");
            isPresent = nameList.Contains("Artem");
            Console.WriteLine(isPresent ? "Artem Yes" : "Artem No");

            Console.WriteLine("");
            Console.WriteLine("Count is {0}", nameList.Count);
            Console.WriteLine("Clear list");
            nameList.Clear();
            Console.WriteLine("Count is {0}", nameList.Count);
            Console.WriteLine("Is list empty {0}", nameList.IsEmpty.ToString());
            _ = Console.ReadLine();
        }

        private static void CheckLinkedList()
        {
            LinkedList<string> nameList = new LinkedList<string>();
            nameList.Add("Tom");
            nameList.Add("Kirill");
            nameList.Add("Maria");
            nameList.Add("Ivan");

            Console.WriteLine("Write initial name list");
            foreach (var name in nameList)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("");
            Console.WriteLine("Remove Kirill and write name list");
            nameList.Remove("Kirill");
            foreach (var name in nameList)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("");
            Console.WriteLine("Remove Tom and write name list");
            nameList.Remove("Tom");
            foreach (var name in nameList)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("");
            Console.WriteLine("Check if Tom exist");
            bool isPresent = nameList.Contains("Tom");
            Console.WriteLine(isPresent ? "Tom Yes" : "Tom No");

            Console.WriteLine("");
            Console.WriteLine("Check if Ivan exist");
            isPresent = nameList.Contains("Ivan");
            Console.WriteLine(isPresent ? "Ivan Yes" : "Ivan No");

            Console.WriteLine("");
            Console.WriteLine("Append Artem");
            Console.WriteLine("Check if Artem exist");
            nameList.AppendFirst("Artem");
            isPresent = nameList.Contains("Artem");
            Console.WriteLine(isPresent ? "Artem Yes" : "Artem No");

            Console.WriteLine("");
            Console.WriteLine("Count is {0}",nameList.Count);
            Console.WriteLine("Clear list");
            nameList.Clear();
            Console.WriteLine("Count is {0}", nameList.Count);
            Console.WriteLine("Is list empty {0}", nameList.IsEmpty.ToString());
            _ = Console.ReadLine();
        }
        private static void CheckStack()
        {
            Stack<string> people = new Stack<string>();
            people.Push("Tom");
            people.Push("Bob");
            people.Push("Sam");
            people.Push("Alice");
            
            Console.WriteLine("Count is {0}", people.Count);
            people.WriteItems();

            Console.WriteLine("");
            Console.WriteLine("Peeked item");
            var head = people.Peek();
            Console.WriteLine(head);

            head = people.Pop();
            Console.WriteLine("");
            Console.WriteLine("Count is {0}", people.Count);
            people.WriteItems();

            Console.WriteLine("");
            Console.WriteLine("Pop to the end");
            while (!people.IsEmpty)
            {
                string person = people.Pop();
                Console.WriteLine(person);
            }
            Console.WriteLine("Count is {0}", people.Count);
            _ = Console.ReadLine();
        }
    }
}
