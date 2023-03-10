using System;

namespace CollectionsPriorityQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue<string, int> customerQueue = new PriorityQueue<string, int>();

            customerQueue.Enqueue("Harry Potter", 5);
            customerQueue.Enqueue("Hermonie Granger", 2);
            customerQueue.Enqueue("Ron Weasley", 1);
            customerQueue.Enqueue("Neville Longbottom", 3);
            customerQueue.Enqueue("Luna Lovegood", 4);

            Console.WriteLine($"There are {customerQueue.Count} customers in the queue");
            var highestCustomer = customerQueue.TryPeek(out string nextName, out int priority);
            Console.WriteLine($"{nextName} is the highest priority in the queue.");
            Console.WriteLine($"Do you want to remove {nextName}? (yes or no)");
            string answer = Console.ReadLine();

            while (answer == "yes")
            {
                customerQueue.TryDequeue(out string exitName, out int exitPriority);
                Console.WriteLine($"{exitName} has been removed from the queue!");
                Console.WriteLine();
                Console.WriteLine($"There are {customerQueue.Count} customers in the queue");
                Console.WriteLine();
                highestCustomer = customerQueue.TryPeek(out nextName, out priority);
                Console.WriteLine($"{nextName} is the now the highest priority in the queue.");
                Console.WriteLine($"Do you want to remove {nextName}? (yes or no)");
                answer = Console.ReadLine();

            }
            Console.WriteLine($"There are {customerQueue.Count} customers left in the queue");

        }
    }
}