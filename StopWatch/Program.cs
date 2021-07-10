using System;

namespace PStopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            
           StopWatch obj = new StopWatch();
            while (true)
            {
                Console.WriteLine("1-Start a timer ");
                Console.WriteLine("2-End the timer");
                Console.WriteLine("3-exit");
                String choice = Console.ReadLine();
                if (choice == "1")
                    obj.start();
                if (choice == "2")
                    Console.WriteLine(obj.end());
                if (choice == "3")
                    break;
                    
            }
        }
    }
}
