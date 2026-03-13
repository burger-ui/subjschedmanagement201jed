using System;
namespace subjschedmanagement
{
    public class Program
    {
        public static void Main(string[] args) {
            bool running = true;

            while (running)
            {

                Menu();
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Add();
                }
                else if (choice == "2")
                {
                    Show();
                }
                else if (choice == "3")
                {
                    running = false;
                    Console.WriteLine("Program ended");
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }
        }
        static string[] subjects = new string[5];
        static string[] schedules = new string[5];
        static int index = 0;

        static void Menu()
        {

            Console.WriteLine("\n1. Add Subjects");
            Console.WriteLine("2. View Subjects");
            Console.WriteLine("3. Exit ");
            Console.Write("choose ");
        }

        static void Add()
        {
            int index = 0;

            for (int i = 1; i < subjects.Length; i++) {

                if (subjects[i] == null) { 
                    index = i; break;
                }
            }

            if (index == 0){

                Console.WriteLine("Subject List is Full");
                return;
            }

            Console.WriteLine("Enter Subject Name: ");
            subjects[index] = Console.ReadLine();

            Console.WriteLine("Enter Schedule: ");
            schedules[index] = Console.ReadLine();

            int count = 0;
            count++;
            Console.WriteLine("Subject added Successfully.");

           
        }

        static void Show()
        {

            if (index == 0)
            {
                Console.WriteLine("No data found.");
                return;
            }
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine((i + 1) + " " + subjects[index] + " - " + schedules[index]);
            }
        }
    }

}