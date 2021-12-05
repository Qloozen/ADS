using System;

class Person {
    public string Name {get; set;}
    public DateTime BirthDay {get;set;}
    public bool isAlive {get;set;}

    public string Gender {get;set;}

    public override string ToString()
    {
        return base.ToString();
    }
}