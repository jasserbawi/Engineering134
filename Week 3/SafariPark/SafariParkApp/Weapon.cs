namespace SafariParkApp;

public abstract class Weapon : IShootable
{
    private string _brand = "";

    public virtual string Shoot()
    {
        return "Pow.";
    }

    public Weapon(string brand)
    {
        _brand = brand;
    }

    public override string ToString()
    {
        return base.ToString() + $" - {_brand}";
    }
}

public class LaserGun : Weapon
{
    public override string Shoot()
    {
        return $"Zing!! Shooting a {base.ToString()}";
    }

    public LaserGun(string brand) : base(brand)
    {
        
    }
}

public class WaterPistol : Weapon
{
    public override string Shoot()
    {
        return $"Splash!! Shooting a {base.ToString()}";
    }

    public WaterPistol(string brand) : base(brand)
    {

    }
}



