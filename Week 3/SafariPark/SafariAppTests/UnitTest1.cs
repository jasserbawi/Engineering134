using SafariParkApp;

namespace SafariAppTests;


public class VehicleTests
{
    [Test]
    public void WhenADefaultVehicleMovesTwiceItsPositionIs20()
    {
        Vehicle v = new Vehicle();
        var result = v.Move(2);
        Assert.AreEqual(20, v.Position);
        Assert.AreEqual("Moving along 2 times", result);
    }

    [Test]
    public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
    {
        Vehicle v = new Vehicle(5, 40);
        var result = v.Move();
        Assert.AreEqual(40, v.Position);
        Assert.AreEqual("Moving along", result);

    }
}

public class Polymorphism
{
    [Test]
    public void GivenCameraPentax_WhenNishMandelCreated_ReturnNishShootingPentax()
    {
        Camera cam = new Camera("Pentax");
        Hunter nish = new Hunter("Nish", "Mandel", cam);

        var result = nish.Shoot();

        Assert.That(result, Is.EqualTo("Nish Mandel: Shooting a SafariParkApp.Camera - Pentax"));
    }

    [Test]
    public void GivenWeaponSupersoaker_WhenNishMandelCreated_ReturnNishSplash()
    {
        WaterPistol pistol = new WaterPistol("Supersoaker");
        Hunter nish = new Hunter("Nish", "Mandel", pistol);

        var result = nish.Shoot();

        Assert.That(result, Is.EqualTo("Nish Mandel: Splash!! Shooting a SafariParkApp.WaterPistol - Supersoaker"));
    }

    [Test]
    public void GivenWeaponAcme_WhenNishMandelCreated_ReturnNishZing()
    {
        LaserGun laserGun = new LaserGun("Acme");
        Hunter nish = new Hunter("Nish", "Mandel", laserGun);

        var result = nish.Shoot();

        Assert.That(result, Is.EqualTo("Nish Mandel: Zing!! Shooting a SafariParkApp.LaserGun - Acme"));
    }
}
