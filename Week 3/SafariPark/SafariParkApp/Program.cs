namespace SafariParkApp;

public class Program
{
    static void Main(string[] args)
    {
        /*        Person alex = new Person("Alex", "Blunt", 20);

                //Since Age is NOT private, it will give mehdi a default value of 0 for his age. However, we assigned the default age to be 18
                Person mehdi = new Person("Mehdi", "Hamdi");
                Console.WriteLine(mehdi.Age);


                Vehicle car = new Vehicle();

                // Object initialisation
                int[] nums = new int[10];

                Person faisal = new Person("Faisal", "Khalaf") { Age = 33, height = 215 }; // This is initialisation of objects
                Person scot = new Person() { FirstName = "Scot", LastName = "Morrison", Age = 33, height = 215 };


                ShoppingList basket = new ShoppingList() { Basket = "Eggs, Bread, Butter" };

                //Structs
                Point3D p = new Point3D(10, 20);
                Point3D p2;

                DoThis(scot, p);*/

        Hunter nish = new Hunter("Nish", "Mandal", "Nikon") { Age = 31 };
        nish.Age = 31;
        Console.WriteLine(nish.Shoot());

        Person jasser = new Person("Jasser", "Bawi");
        Person jassersTwin = new Person("Jasser", "Bawi");

        /*Console.WriteLine(jasser.Equals(jassersTwin)); // these are 2 different objects
        Console.WriteLine(jasser.GetType());

        Console.WriteLine(jasser); // we use our created ToString method

        Console.WriteLine(nish);*/

        /*Cat Cat = new Cat();
        Console.WriteLine(Cat.Call());
        Console.WriteLine(Cat.Move());
        Console.WriteLine($"The animal has {Cat.Legs()} legs.");

        Dog Dog = new Dog();
        Console.WriteLine(Dog.Call());
        Console.WriteLine(Dog.Move());
        Console.WriteLine($"The animal has {Dog.Legs()} legs.");*/

        Airplane plane = new Airplane(20);
        Console.WriteLine(plane.Move());
        plane.Ascend(5);

        Airplane plane2 = new Airplane(50, 3, "EasyJet");
        Console.WriteLine(plane2.Move());
        plane2.Descend(5);
        plane2.ToString();


    }

    public static void DoThis(Person person, Point3D point)
    {
        person.Age = 100;
        point.z = 1_000_000; // the value of p will not change as z is not going to be changed
    }
}