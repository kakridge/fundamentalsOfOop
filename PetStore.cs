using System;
using System.Collections.Generic;

namespace FundamentalsOfOop
{
    public class PetStore
    {
        private readonly List<Animal> _animals = new List<Animal>();

        public void AddInventory(Animal animal)
        {
            Console.WriteLine($"Adding {animal.Name}, a {animal.GetType().Name}.");
            _animals.Add(animal);
        }

        public void ShowInventory()
        {
            _animals.ForEach(animal =>
            {
                Console.WriteLine(
                    $"\n{animal.Name} is an {animal.GetType().BaseType.Name} of type {animal.GetType().Name}.  " +
                    $"It is {animal.Age} years old and weighs {animal.Weight} pounds");
                Console.WriteLine($"Say hello {animal.Name}");
                Console.WriteLine($"{animal.Name} says {animal.Speak()}");
            });
        }
    }
}