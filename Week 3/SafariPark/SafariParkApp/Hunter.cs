namespace SafariParkApp;

public class Hunter : Person
{
    //Fields
    private string _camera;

    //Methods
    // Since _fistName is private and we want to access it, we do: public Hunter(...) : base(fName, lName)
    public Hunter(string fName, string lName, string camera = "") : base(fName, lName)
    {
        _camera = camera;
    }

    public Hunter() { }

    public string Shoot()
    {
        return $"{FullName()} has taken a photo with their {_camera}";
    }

    public override string ToString()
    {
        return $"{base.ToString()} and a {_camera} camera";
    }

    public override string FullName()
    {
        return "test";
    }
}
