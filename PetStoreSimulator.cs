using System;

namespace FundamentalsOfOop
{
    public class PetStoreSimulator
    {
        public void Simulate()
        {
            Console.WriteLine("Welcome to the Pet Store Simulator");
            Console.Read();
            Console.WriteLine("\nAdding inventory");
            Console.ReadLine();
            var petStore = new PetStore();
            var bird = createBird();
            var cat = createCat();
            var dog = createDog();
            petStore.AddInventory(bird);
            petStore.AddInventory(cat);
            petStore.AddInventory(dog);
            Console.WriteLine("\nShowing inventory");
            Console.ReadLine();
            petStore.ShowInventory();
        }

        private Dog createDog()
        {
            var dog = new Dog {Name = "Charlie", Age = 3, Weight = 35};
            return dog;
        }

        private Cat createCat()
        {
            var cat = new Cat {Name = "Mittens", Age = 2, Weight = 8};
            return cat;
        }

        private Bird createBird()
        {
            var bird = new Bird {Name = "Skittles", Age = 5, Weight = 2};
            return bird;
        }
    }
}