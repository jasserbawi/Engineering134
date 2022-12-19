using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp;

public abstract class Vehicle
{
    private int _capacity;
    private int _numPassengers;

    public int NumPassengers
    {
        get
        {
            return _numPassengers;
        }
        set
        {
            if (value >= 0 && value <= _capacity) _numPassengers = value;
        }
    }

    public int Position { get; set; }

    public int Speed { get; init; }

    public virtual string Move()
    {
        Position += Speed;
        return "Moving along";
    }

    public virtual string Move(int times)
    {
        Position += times * Speed;
        return $"Moving along {times} times";
    }

    //Constructors
    public Vehicle()
    {
        Speed = 10;
    }

    public Vehicle(int capacity, int speed = 10)
    {
        _capacity = capacity;
        Speed = speed;
    }

}

public class Airplane : Vehicle
{
    private string _airline;

    public int Altitude { get; set; }

    public void Ascend(int distance)
    {
        Altitude += distance;
    }

    public void Descend(int distance)
    {
        Altitude -= distance;
    }

    public override string Move()
    {
        Position += Speed;
        return "Moving along";
    }

    public override string Move(int times)
    {
        Position += Speed*times;
        return $"Moving along {times} times";

    }

    public Airplane(int capacity) : base(capacity)
    {
    }

    public Airplane(int capacity, int speed, string airline) : base(capacity, speed)
    {
        _airline = airline;
    }

    public override string ToString()
    {
        var PositionResult = "";
        if (Altitude < 0)
        {
            PositionResult = "You have crashed and died.";
        }
        else
        {
            PositionResult = $"The {_airline} plane altitude has moved {Altitude} ";
        }
        return PositionResult;
    }
}