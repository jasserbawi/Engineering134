namespace SafariParkApp;

public class Hunter : Person, IShootable
{
    public IShootable Shooter { get; set; }

    //Methods
    // Since _fistName is private and we want to access it, we do: public Hunter(...) : base(fName, lName)
    public Hunter(string fName, string lName, IShootable shooter) : base(fName, lName)
    {
        Shooter = shooter;
    }

    public Hunter() { }

    public string Shoot()
    {
        return $"{base.ToString()}: {Shooter.Shoot()}";
    }

    public override string ToString()
    {
        return $"{base.ToString()} and a {Shooter} camera";
    }
}
