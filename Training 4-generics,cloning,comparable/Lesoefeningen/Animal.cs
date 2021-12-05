using System;

public abstract class Animal : ICloneable{
    public string name;
    public int age;

    public Animal(string name)
    {
        this.name = name;
    }

    public string MakeSound() {
        return string.Format("{0}:{1}!", name, GetSound());
    }

    public abstract string GetSound();

    abstract public object Clone();
}

class Dog : Animal, IComparable<Dog>
{
    public Dog(string name, int age) : base(name){
        this.age = age;
    }

    public Dog(Dog otherDog) : base(otherDog.name){
        
    }

    public override string GetSound()
    {
        return "WOOF";
    }

    public void BeAGoodBoy() {
        // Aparte eigenschap van een hond
    }

    public override object Clone()
    {
        return new Dog(this);
    }

    public int CompareTo(Dog other)
    {
        // return = this.name.CompareTo(other.name);  // sorteer op naam
        // return this.age -  other.age;  //sorteer op leeftijd

        // Sorteren op leeftijd, daarna op naam
        if(this.age - other.age != 0) {
            return this.age - other.age;
        } else {
            return this.name.CompareTo(other.name);
        }
    }
}

class Cat : Animal
{
    public Cat(string name, int age) : base(name){
        this.age = age;
    }
    public Cat(Cat othertCat) : base(othertCat.name){
        
    }

    public override string GetSound()
    {
        return "MEEOOOW!";
    }

    public void BeStubborn() {}

    public override object Clone()
    {
        return new Cat(this);
    }
}