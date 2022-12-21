namespace SafariParkApp;

public class Vehicle : IMoveable, IEquatable<Vehicle?>
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

    public override string ToString()
    {
        return base.ToString() + $" Passengers: {NumPassengers} capacity {_capacity}";
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as Vehicle);
    }

    public bool Equals(Vehicle? other)
    {
        return other is not null &&
               _capacity == other._capacity &&
               Speed == other.Speed;
               base.Equals(other);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_capacity, Speed);
    }
}




public class Airplane : Vehicle, IEquatable<Airplane?>, IComparable<Airplane>
{
    private string _airline = "";

    private int _altitude = 0;

    public int Altitude
    {
        get
        {
            return _altitude;
        }
        set
        {
            if (value >= 0 ) { _altitude = value; }
            else
            {
                throw new ArgumentException("You crashed.");
            }
        }
    }

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
        return base.ToString() + $"The {_airline} plane has altitude {_altitude} and position {Position}";
    }


    // IEquatable
    public override bool Equals(object? obj)
    {
        return Equals(obj as Airplane);
    }

    public bool Equals(Airplane? other)
    {
        return other is not null &&
               NumPassengers == other.NumPassengers &&
               base.Equals(other);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(NumPassengers, base.GetHashCode());
    }

    public int CompareTo(Airplane? other)
    {
        if (other is null) { throw new Exception(); }

        // return less than zero if altitude is greater than other.Altitude
        // return 0 if equal
        // return > 0 if altitude < other.Altitude
        if (Altitude > other.Altitude)
        {
            return -1;
        }
        else if (Altitude == other.Altitude)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }

    public static bool operator == (Airplane left, Airplane right)
    {
        return EqualityComparer<Airplane>.Default.Equals(left, right);
    }

    public static bool operator !=(Airplane left, Airplane right)
    {
        return !(left == right);
    }
}