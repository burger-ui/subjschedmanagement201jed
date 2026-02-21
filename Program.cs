namespace subjschedmanagement
{
    public class Program
    {
        static string[] subjects = new string[5];
        static string[] schedules = new string[5];
        static int index = 0;

        static void subchoice()
        {

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

        static void Menu()
        {

            Console.WriteLine("\n 1. Add Subjects");
            Console.WriteLine("2. View Subjects");
            Console.WriteLine("3. Exit ");
            Console.Write("choose ");
        }

        static void Add()
        {

            if (index >= 5)
            {
                Console.WriteLine("List is Full ");
                return;
            }

            Console.WriteLine("Subject");
            subjects[index] = Console.ReadLine();

            Console.WriteLine("Schedule");
            schedules[index] = Console.ReadLine();

            index++;
            Console.WriteLine("the schedule you set is saved");
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
                Console.WriteLine((i + 1) + " " + subjects[i] + " - " + schedules[i]);
            }
        }
    }

}
