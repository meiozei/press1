using System;

namespace output
{
    class Gay
    {
        static void Main(string[] args)
        {
            while(true) {
                Console.WriteLine("Press 1 to know something good");
                int bruhMoment = Int32.Parse(Console.ReadLine());

                switch (bruhMoment) { 
                    case 1: 
                    if (bruhMoment == 1) {
                        Console.WriteLine("Haha you're fuckin' gay");
                        System.Environment.Exit(1);
                    }
                    break;
                    case 2: 
                    if (bruhMoment < 1) {
                        Console.WriteLine("Omg what I said 1");
                        return;
                    }
                    break;
                    case 3: 
                    if (bruhMoment > 1) {
                        Console.WriteLine("I SAID ONE. 1.");
                        return;
                    }
                    break;

                    default: 
                    Console.WriteLine("Pick 1 :eyes:");
                    continue;
                }
            }
        }
    }
}
