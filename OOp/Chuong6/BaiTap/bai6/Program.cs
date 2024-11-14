using System;

abstract class Animal
{
    protected string Type;

    public Animal(string type)
    {
        Type = type;
    }

    public abstract string Sound();
    public abstract string Info();
}

class Dog : Animal
{
    public string Name { get; set; }
    public string Breed { get; set; }

    public Dog(string name, string breed) : base("Mammal")
    {
        Name = name;
        Breed = breed;
    }

    public override string Sound()
    {
        return "Woof!";
    }

    public override string Info()
    {
        return $"Dog: {Name}, Breed: {Breed}, Type: {Type}";
    }
}

class Cat : Animal
{
    public string Name { get; set; }

    public Cat(string name) : base("Mammal")
    {
        Name = name;
    }

    public void Climb(string objectToClimb)
    {
        Console.WriteLine($"{Name} is climbing the {objectToClimb}.");
    }

    public override string Sound()
    {
        return "Meow!";
    }

    public override string Info()
    {
        return $"Cat: {Name}, Type: {Type}";
    }
}

class Duck : Animal
{
    public string Name { get; set; }

    public Duck(string name) : base("Bird")
    {
        Name = name;
    }

    public void Swim(string placeToSwim)
    {
        Console.WriteLine($"{Name} is swimming in the {placeToSwim}.");
    }

    public override string Sound()
    {
        return "Quack!";
    }

    public override string Info()
    {
        return $"Duck: {Name}, Type: {Type}";
    }
}
class Program
{
    static void Main()
    {
        Animal dog = new Dog("Buddy", "Spaniel");
        Animal cat = new Cat("Whiskers");
        Animal duck = new Duck("Daisy");

        Console.WriteLine(dog.Info());
        Console.WriteLine("Sound: " + dog.Sound());

        Console.WriteLine(cat.Info());
        Console.WriteLine("Sound: " + cat.Sound());
        ((Cat)cat).Climb("tree");

        Console.WriteLine(duck.Info());
        Console.WriteLine("Sound: " + duck.Sound());
        ((Duck)duck).Swim("pond");
    }
}
