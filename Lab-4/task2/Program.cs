using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandCentre = new CommandCentre();
            var runway1 = new Runway(commandCentre);
            var runway2 = new Runway(commandCentre);
            
            commandCentre.RegisterRunway(runway1);
            commandCentre.RegisterRunway(runway2);
            
            var aircraft1 = new Aircraft(commandCentre, "Boeing 747");
            var aircraft2 = new Aircraft(commandCentre, "Airbus A320");
            var aircraft3 = new Aircraft(commandCentre, "Cessna 172");
            commandCentre.RegisterAircraft(aircraft1);
            commandCentre.RegisterAircraft(aircraft2);
            commandCentre.RegisterAircraft(aircraft3);

            Console.WriteLine("=== Demonstrating Aircraft Landing ===");
            aircraft1.Land();
            aircraft2.Land();
            aircraft3.Land();

            Console.WriteLine("\n=== Demonstrating Aircraft Takeoff ===");
            aircraft1.TakeOff();
            
            Console.WriteLine("\n=== Demonstrating Aircraft Landing after Takeoff ===");
            aircraft3.Land();
            
            aircraft2.TakeOff();
            aircraft3.TakeOff();
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
} 