namespace SafariParkApp;

public class Program
{
    static void Main(string[] args)
    {
        #region Previous work
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

        /*Hunter nish = new Hunter("Nish", "Mandal", "Nikon") { Age = 31 };*/
        // nish.Age = 31;
        /*Console.WriteLine(nish.Shoot());*/

        /*Person jasser = new Person("Jasser", "Bawi");
        Person jassersTwin = new Person("Jasser", "Bawi");

        Console.WriteLine(jasser.Equals(jassersTwin)); // these are 2 different objects
        Console.WriteLine(jasser.GetType());

        Console.WriteLine(jasser); // we use our created ToString method*/


        Cat Cat = new Cat();
        /*Console.WriteLine(Cat.Call());
        Console.WriteLine(Cat.Move());
        Console.WriteLine($"The animal has {Cat.Legs()} legs.");

        Dog Dog = new Dog();
        Console.WriteLine(Dog.Call());
        Console.WriteLine(Dog.Move());
        Console.WriteLine($"The animal has {Dog.Legs()} legs.");*/

        /*Airplane plane = new Airplane(20);
        Console.WriteLine(plane.Move());
        plane.Ascend(5);

        Airplane plane2 = new Airplane(50, 3, "EasyJet");
        Console.WriteLine(plane2.Move());
        plane2.Descend(5);
        plane2.ToString();*/

        /*        List<Object> safariObjects = new()
                {
                    jasser,
                    jassersTwin,
                    Cat,
                    new Vehicle(12, 100) {NumPassengers = 6},
                };*/

        /*foreach(IMoveable obj in safariObjects)
        {
            SpartaWrite(obj);
        }*/

        /*IMoveable mover = jasser;*/

        /*Console.WriteLine(mover.Move());

        mover = nish;

        Console.WriteLine(mover.Move());

        mover = new Airplane(25);

        Console.WriteLine(mover.Move());*/


        /*        Console.WriteLine("Polymorphic shootout");

                Camera pentax = new Camera("Pentax");

                WaterPistol pistol = new WaterPistol("Supersoaker");
                LaserGun laserGun = new LaserGun("Acme");

                Hunter nish = new Hunter("Nish", "Mandal", pentax);

                Console.WriteLine(nish.Shoot());

                nish.Shooter = pistol;
                Console.WriteLine(nish.Shoot());

                nish.Shooter = laserGun;
                Console.WriteLine(nish.Shoot());

                nish.Shooter = pistol;
                Console.WriteLine(nish.Shoot());



                List<IShootable> weapons = new()
                {
                    new WaterPistol("WaterRifle"),
                    new LaserGun("LaserRifle"),
                    new WaterPistol("LaserPistol"),
                    new Hunter("Nish", "Mandel", pentax),
                    new Hunter("John", "Smith", pentax),
                    new Camera("Nikon")
                };*/

        /*        foreach(IShootable obj in weapons)
                {
                    Shooter(obj);
                }*/
        #endregion

        #region Equality
        /*       var bobOne = new Person("Bob", "Builder");
               var bobTwo = bobOne;

               bobTwo.Age = 36;

               Console.WriteLine("bobone equals bobtwo? " + bobOne.Equals(bobTwo));

               var cesna = new Airplane(5);
               var bushPlane = new Airplane(5);
               bushPlane.Ascend(300);

               Console.WriteLine("Cesna is busPlane? " + cesna.Equals(bushPlane));

               List<Airplane> planes = new()
               {
                   cesna,
                   bushPlane,
                   new Airplane(15) {Altitude = 200}
               };

               planes.Sort();*/
        #endregion

        #region List
        /*        List<Person> people = new()
                {
                    new Person("Alex", "Blunt"),
                    new Person("Mohammed", "Ali"),
                    new Person("Ikra", "Dahir")
                };

                foreach (Person p in people)
                {
                    Console.WriteLine(p.FirstName);
                }

                List<int> ints = new() { 5, 4, 3, 9, 0 };
                ints.Add(8);
                ints.Sort();
                ints.RemoveRange(1, 2);
                ints.Insert(2, 1);
                ints.Reverse();
                ints.Remove(9);

                foreach (int item in ints)
                {
                    Console.WriteLine(item);
                }*/
        #endregion

        #region Queue
        // QUEUE
        /*        Queue<Person> peopleQueue = new();
                peopleQueue.Enqueue(new Person("Alex", "Blunt")); // Adds to the queue and Alex will be first
                peopleQueue.Enqueue(new Person("Mohammed", "Ali")); // Second
                peopleQueue.Enqueue(new Person("Ikra", "Dahir")); // Last

                Console.WriteLine(peopleQueue.Dequeue());

                Stack<Person> peopleStack = new();
                peopleStack.Push(new Person("Alex", "Blunt")); // Bottom/Last
                peopleStack.Push(new Person("Mohammed", "Ali")); // Middle
                peopleStack.Push(new Person("Ikra", "Dahir")); // Ikra will be on the top of the list

                Console.WriteLine(peopleStack.Pop()); // Removes ikra who is first on the stack

                int[] original = new int[] { 1, 2, 3, 4, 5 };
                int[] reversed = new int[original.Length];
                var stack = new Stack<int>();

                foreach (int i in original)
                {
                    stack.Push(original[i - 1]);
                }

                for (int i = 0; i < reversed.Length; i++)
                {
                    reversed[i] = stack.Pop();
                }*/
        #endregion


        #region Hash Set
        // Hash set
        /*        var planeSet = new HashSet<Airplane>
                {
                    new Airplane(5) {Speed = 10, Altitude = 5 },
                    new Airplane(15) {Speed = 20, Altitude = 50 },
                    new Airplane(35) {Speed = 30, Altitude = 500 },
                    new Airplane(35) {Speed = 30, Altitude = 500 } // Since this is a duplicate of the above, they have the same hash code so the hashset only has 3 items because theyre duplciates
                };

                foreach (var plane in planeSet) Console.WriteLine(plane);

                var plane1 = new Airplane(1);
                var plane2 = new Airplane(1);

                bool addCapacity5Plane = planeSet.Add(plane1);
                bool addCapacity5PlaneAgain = planeSet.Add(plane2); // should return false because the plane was already added above so it wont add duplicate*/
        #endregion


        #region Dictionary
        //Dictionary <key, value>

        var personDict = new Dictionary<string, Person>()
        {
            {"Tasheer", new Person("Mohammed", "Ali") },
            {"Nah", new Person("Mehdi", "Hamdi") },
            {"No", new Person("Scot", "Morrison") }
        };

        Console.WriteLine(personDict["Tasheer"]);
        personDict.Add("Maj", new Person("Maajid", "Ali"));

        var keys = personDict.Keys.ToArray(); //collection of keys
        var values = personDict.Values.ToArray(); //collection of values

        foreach(var kvp in personDict)
        {
        }

        string input = "The cat in the hat comes back";


        var countDict = new Dictionary<char, int>();

        foreach(char c in input.ToLower())
        {
            if (c == ' ')
            {
            }
            else if (countDict.ContainsKey(c))
            {
                countDict[c] += 1;
            }
            else
            {
                countDict.Add(c, 1);
            }
        }

        foreach(var dict in countDict)
        {
            Console.WriteLine(dict);
        }

        #endregion
    }

    private static void Shooter(IShootable shootable)
    {
        if (shootable is Weapon) // "is" is an operator ---> this if statement is important so that the object can be casted to a person underneath
        {
            var shooter = (Weapon)shootable; // if the object is a person (casted using () ) then print the person fullname.
            Console.WriteLine(shootable.Shoot());
        }
        else if (shootable is Hunter)
        {
            var shooter = (Hunter)shootable; // if the object is a person (casted using () ) then print the person fullname.
            Console.WriteLine(shootable.Shoot());
        }
        else if (shootable is Camera)
        {
            var shooter = (Camera)shootable; // if the object is a person (casted using () ) then print the person fullname.
            Console.WriteLine(shootable.Shoot());
        }
    }

    private static void SpartaWrite(IMoveable moveable)
    {
        if (moveable is Person) // "is" is an operator ---> this if statement is important so that the object can be casted to a person underneath
        {
            var person = (Person)moveable; // if the object is a person (casted using () ) then print the person fullname.
            Console.WriteLine(person.FullName());
        }
        Console.WriteLine(moveable.Move());
        Console.WriteLine(moveable.Move(2));
    }

    public static void DoThis(Person person, Point3D point)
    {
        person.Age = 100;
        point.z = 1_000_000; // the value of p will not change as z is not going to be changed
    }
}