﻿namespace SafariParkApp;

public class Camera : IShootable
{
    private string _brand = "";

    public Camera(string brand)
    {
        _brand = brand;
    }

    public string Shoot()
    {
        return $"Shooting a {base.ToString()} - {_brand}";
    }

    public override string ToString()
    {
        return base.ToString() + $"The camera brand is {_brand}";
    }
}
