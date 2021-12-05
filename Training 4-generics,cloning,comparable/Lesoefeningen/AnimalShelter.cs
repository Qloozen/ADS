using System;
using System.Collections.Generic;

public class AnimalShelter<T> where T : Animal { // <-- Generic kan hierdoor alleen implementaties van Animal toepassen
    private List<T> animals;

    public AnimalShelter()
    {
        animals = new List<T>();
    }

    public AnimalShelter(AnimalShelter<T> otherShelter) {
        animals = new List<T>(); // hiermee wordt de lijst (structuur) gekopieerd

        foreach (T animal in otherShelter.animals)
        {
            animals.Add((T) animal.Clone()); // .Clone geeft de nieuwe animal terug in Object vorm, cast naar T kan altijd.
        }
    }

    public void Add(T newAnimal) {
        animals.Add(newAnimal);
    }

    public void MakeNoise() {
        foreach (T animal in animals)
        {
            Console.WriteLine(animal.MakeSound());            
        }

    }
}