namespace MethodsApp;

public class Program
{
    static void Main(string[] args)
    {
        int result = DoThis(10, "hungry");

        //an optional parameter
        int result2 = DoThis(5);

        // Using out variable (do in input)
        string outVariable = "I'm feeling hungry";
        int result3 = DoThisOut(1, "not hungry", out outVariable);

        //named parameter
        DoThis(x: 5, y: "Sleepy");
        Console.WriteLine(OrderPizza(pepperoni: true, olives: false, sweetcorn: false, chicken: false, greenPeppers: true));

        //Tuples
        (string, string, int) person = ("Joe", "Bloggs", 25);
        Console.WriteLine(person.Item1);
        Console.WriteLine(person.Item2);
        Console.WriteLine(person.Item3);

        var student = (fName: "Mehdi", lName: "Hamdi", age: 24);  // Able to specify the name to identify the information
        Console.WriteLine(student.fName);
        Console.WriteLine(student.lName);
        Console.WriteLine(student.age);

        // Tuples as a return type
        var weight = ConvertPoundsToStonesAndPounds(156);
        Console.WriteLine(weight.stones + " stones and " + weight.pounds + " pounds.");
    }

    public static int DoThis(int x, string y = "happy")
    {
        Console.WriteLine($"I'm feeling {y}");
        return x * x;
    }

    public static int DoThisOut(int x, string y, out string result)
    {
        result = $"I'm feeling {y}";
        return x * x;
    }

    public static string OrderPizza(bool greenPeppers, bool pepperoni, bool chicken, bool sweetcorn, bool olives)
    {
        var pizza = "Pizza with tomato sauce, cheese, ";
        if (greenPeppers) pizza += "green peppers, ";
        if (pepperoni) pizza += "pepperoni, ";
        if (chicken) pizza += "chicken, ";
        if (sweetcorn) pizza += "sweetcorn, ";
        if (olives) pizza += "olives, ";
        return pizza + "only.";
    }

    public static (int stones, int pounds) ConvertPoundsToStonesAndPounds(int pounds)
    {
        const int poundsInAStone = 14;
        var st = pounds / poundsInAStone;
        var lbs = pounds % poundsInAStone;
        return (st, lbs);
    }
}