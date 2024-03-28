using System;
namespace Assignment1EasyRewardz
{
public class IntegerList
    {
        private List<int> list;

        public IntegerList()
        {
            list = new List<int>();
        }

        public void Add(int num)
        {
            list.Add(num);
        }

        public void Remove(int num)
        {
            if (list.Contains(num))
            {
                list.Remove(num);
            }
            else
            {
                Console.WriteLine("Number not found in list");
            }
        }

        public void PrintList()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                foreach (int num in list)
                {
                    Console.WriteLine(num);
                }
            }
        }

        public static void Main(string[] args)
        {
            IntegerList list = new IntegerList();

            while (true)
            {
                Console.WriteLine("Enter a command (add, remove, print, or quit): ");
                string command = Console.ReadLine().ToLower();

                if (command == "quit")
                {
                    break;
                }
                else if (command == "add")
                {
                    Console.WriteLine("Enter a number to add: ");
                    int num;
                    try
                    {
                        num = int.Parse(Console.ReadLine());
                        list.Add(num);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                    }
                }
                else if (command == "remove")
                {
                    Console.WriteLine("Enter a number to remove: ");
                    int num;
                    try
                    {
                        num = int.Parse(Console.ReadLine());
                        list.Remove(num);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                    }
                }
                else if (command == "print")
                {
                    list.PrintList();
                }
                else
                {
                    Console.WriteLine("Invalid command");
                }
            }
        }
    

}
}
