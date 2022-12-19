namespace SafariParkApp;

public class Program
{
    static void Main(string[] args)
    {
        Person alex = new Person("Alex", "Blunt", 20);

        //Since Age is NOT private, it will give mehdi a default value of 0 for his age. However, we assigned the default age to be 18
        Person mehdi = new Person("Mehdi", "Hamdi");
        Console.WriteLine(mehdi.Age);

        Person faisal = new Person();

        Vehicle car = new Vehicle();
    }
}