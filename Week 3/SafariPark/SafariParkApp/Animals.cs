namespace SafariParkApp;

public abstract class Animal // This is an abstract class
{
    public string Name { get; set; }

    public virtual string Call() // mark it as virtual so the specific animals can override the call
    {
        return "ah";
    }

    public abstract string Move(); // needs to be marked abstract, this has to be overriden in the specific animals

    public abstract int Legs();

}

public class Cat : Animal
{
    public override string Call()
    {
        return "Meow";
    }

    public override string Move()
    {
        return "Saunters";
    }

    public override int Legs()
    {
        return 4;
    }

}

public class Dog : Animal
{
    public override string Call()
    {
        return "Woof";
    }

    public override string Move()
    {
        return "Trots";
    }

    public override int Legs()
    {
        return 4;
    }
}
