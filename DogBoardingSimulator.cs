using System;

namespace FundamentalsOfOop
{
    public class DogBoardingSimulator
    {
        private readonly BoardingKennel _boardingKennel = new BoardingKennel();

        private readonly string menu = "\nPlease select one of the following options: "
                                       + "\n1. Board a dog"
                                       + "\n2. Retrieve a dog"
                                       + "\n3. Get number of dogs in kennel"
                                       + "\n4. Exit";

        public void Simulate()
        {
            Console.WriteLine("Welcome to the Boarding Kennel Simulator");
            while (true)
            {
                Console.WriteLine(menu);
                var command = Console.ReadLine();
                if (command == "1")
                {
                    Console.Write("\nPlease enter the dog's name: ");
                    var name = Console.ReadLine();
                    Console.Write("\nPlease enter the dog's age: ");
                    var age = Console.ReadLine();
                    Console.Write("\nPlease enter the dog's weight: ");
                    var weight = Console.ReadLine();

                    var dog = new BoardedDog
                    {
                        Name = name,
                        Age = int.Parse(age),
                        Weight = int.Parse(weight)
                    };
                    _boardingKennel.HouseDog(dog);
                }

                if (command == "2")
                {
                    Console.Write("\nPlease enter the dog's name: ");
                    var name = Console.ReadLine();
                    var dog = _boardingKennel.RetrieveDog(name);
                    Console.WriteLine(
                        $"\nHere is your dog named {dog.Name}, which is {dog.Age} years old and weighs {dog.Weight} pounds.");
                }

                if (command == "3")
                    Console.WriteLine($"\nThere are currently {_boardingKennel.BoardedDogs} dogs in the kennel.");

                if (command == "4") return;
            }
        }
    }
}