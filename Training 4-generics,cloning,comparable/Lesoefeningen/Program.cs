using System;
using System.Collections.Generic;

namespace Lesoefeningen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cloning();
            Comparing();
        }

        public static void Cloning() {
            AnimalShelter<Dog> dogShelter = new AnimalShelter<Dog>();
            Dog fikkie = new Dog("fikkie", 5);
            dogShelter.Add(fikkie);
            dogShelter.Add(new Dog("samson", 6));
            //dogShelter.MakeNoise();

            AnimalShelter<Dog> shallowDogShelter = dogShelter; // Shallow copy (alleen kopie reference)
            //shallowDogShelter.Add(new Dog("fido"));

            //dogShelter.MakeNoise();

            AnimalShelter<Dog> deepDogShelter = new AnimalShelter<Dog>(dogShelter); // dogshelter door constructor die je gaat kopieren
            fikkie.name = "fido";

            //dogShelter.MakeNoise();
            deepDogShelter.MakeNoise();
        }
    
        public static void Comparing() {
            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog("fikkie", 12));
            dogs.Add(new Dog("fido", 4));
            dogs.Add(new Dog("samson", 7));

            dogs.Sort();

            foreach(Dog dog in dogs) {
                Console.WriteLine("{0} is {1} years", dog.name, dog.age);
            }
        }
    }
}
