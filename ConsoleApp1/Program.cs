using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> months = new Dictionary<int, string>();
            months.Add(1, "yanvar");
            months.Add(2, "fevral");
           
           

            HashSet<int> hasset = new HashSet<int>();
            hasset.Add(1);
            hasset.Add(2);
            foreach (int item in hasset)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("============================");

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("14");
            queue.Enqueue("3");
            queue.Enqueue("7");
            foreach (string item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("============================");


            Stack<int> stack = new Stack<int>();
            stack.Push(14);
            stack.Push(3);
            stack.Push(7);
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("===========================================");
            Console.WriteLine("sortedlist");

            SortedList sortedList = new SortedList();

          
            sortedList.Add("remzi", 1);
            sortedList.Add("seymur", 15);
            sortedList.Add("sadiq", 18);
            sortedList.Add("hadi", 9);

          
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine($"Name: {item.Key}, Age: {item.Value}");
            }



        }
    }
}