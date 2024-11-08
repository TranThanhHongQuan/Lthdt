namespace AbstractionDemo;
class Program
{
    static void Main(string[] args)
    {
        Dog dog1 = new Dog();
        dog1.Name = "Đen";
        System.Console.WriteLine(dog1.ToString());
        dog1.Eat();

        Duck duck1 = new Duck();
        duck1.Name = "Lucky";
        System.Console.WriteLine(duck1);
        duck1.Eat();
    }
}
