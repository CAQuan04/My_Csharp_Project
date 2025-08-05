Queue<string> customers = new Queue<string>();
while (true)
{
    Console.WriteLine("\n1. Add new customer");
    Console.WriteLine("2. Call the next customer");
    Console.WriteLine("3. Show list customers");
    Console.WriteLine("0. Exit");
    Console.WriteLine("Please choose a function: ");
    int choice = int.Parse(Console.ReadLine());
    switch(choice)
    {
        case 1:
            Console.Write("Enter customer name: ");
            customers.Enqueue(Console.ReadLine());//Enqueue adds an item to the end of the queue
            break;
        case 2:
            if (customers.Count > 0)
                Console.WriteLine($"Call customer: {customers.Dequeue()}");//Dequeue removes and returns the item at the front of the queue
            else
                Console.WriteLine("Customer queue is empty.");
            break;
        case 3:
            Console.WriteLine("List of customers in queue:");
            foreach (string s in customers)
                Console.Write("{0}, ", s);
            break;
        case 0:
            Console.WriteLine("Exiting the program.");
            return;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;

    }
}