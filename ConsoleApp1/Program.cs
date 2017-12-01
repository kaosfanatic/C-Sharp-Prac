using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string recipient;
            int option;

            option = Menu();

            switch (option)
            {
                case 1:
                    Basics.Hello();
                    break;
                case 2:
                    Console.Write("Enter recipient: ");
                    recipient = Console.ReadLine();
                    Basics.Hello(recipient);
                    break;
            }
        }

        static int Menu()
        {
            int selected = 0;
            bool input = false;
            while (!input)
            {
                Console.WriteLine("Select from the following options:");
                Console.WriteLine("1. Generic\n2. Specific\n");
                Console.Write("Input: ");

                try
                {
                    selected = int.Parse(Console.ReadLine());
                    
                    if(selected == 1 || selected == 2)
                        input = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid input");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error has occured");
                }
            }

            return selected;
        }
        
    }

    public static class Basics
    {
        public static void Hello()
        {

            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }
        public static void Hello(string recipient)
        {
            Console.WriteLine("\nHello, " + recipient + '!');
            Console.ReadLine();
        }
    }
}
