using System;

namespace Example_1_Interface
{

    class Program
    {
        static void Main()
        {
            ConsoleLogger consoleLogger = new ConsoleLogger();

            FileLogger fileLogger = new FileLogger();

            //consoleLogger.Log("System started");

            //fileLogger.Log("Saving Data ");


            Console.WriteLine("Select Logger: 1 = Console, 2 = File");
            int choice = Convert.ToInt32(Console.ReadLine());

            ILogger logger;

            if (choice == 1)
                logger = new ConsoleLogger();
            else
                logger = new FileLogger();

            logger.Log("User selected logger");
        }
    }
}
