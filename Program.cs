using System;

namespace FundamentalsOfOop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var dogBoardingSimulator = new DogBoardingSimulator();
            dogBoardingSimulator.Simulate();

            Console.WriteLine("Press enter to continue to next simulation");
            Console.ReadLine();

            var timeMachineSimulator = new TimeMachineSimulator();
            timeMachineSimulator.Simulate();

            Console.WriteLine("Press enter to continue to next simulation");
            Console.ReadLine();

            var petStoreSimulator = new PetStoreSimulator();
            petStoreSimulator.Simulate();

            Console.WriteLine("Press enter to continue to exit");
            Console.ReadLine();
        }
    }
}