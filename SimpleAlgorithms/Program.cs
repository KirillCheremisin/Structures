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
            CheckLinkedList();
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
    }
}
