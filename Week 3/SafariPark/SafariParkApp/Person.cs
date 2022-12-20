using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class Person : IMoveable
    {
        //fields
        private string _firstName = ""; //This is a backing field
        private string _lastName = ""; //This is a backing field
        private readonly string _eyeColour = "";


        //property
        public int Position { get; set; }
        public int Speed { get; init; }

        public string FirstName //Initialisation
        {
            get
            {
                return _firstName;
            }
            init
            {
                _firstName = value;
            }
        }

        public string LastName //Initialisation
        {
            get
            {
                return _lastName;
            }
            init
            {
                _lastName = value;
            }
        }
        public int Age { get; set; } = 18;

        // backing field
        private int _height = 0;
        public int height
        {
            // getter method (must return something!)
            get
            {
                return _height;
            }
            // setter method (has a hidden input value which can be accessed using value)
            set
            {
                if (value < 0) _height = value;
            }
        }


        public int GetHeight() // private _height is protected but can now be called
        {
            return _height;
        }

        public void SetHeight(int newHeight) // modifies the value of _height
        {
            if (newHeight < 0) _height = newHeight;
        } 

        //method
        public virtual string FullName()
        {
            return _firstName + " " + _lastName;
        }

        //constuctor (kind of a method)
        public Person(string firstName, string lastName, int age)
        {
            _firstName = firstName;
            _lastName = lastName;
            Age = age;
        }

        //Method Overloading
        //Constructor Overloading
        public Person(string firstName, string lastName) // using the same name as constructor above
        {
            _firstName = firstName;
            _lastName = lastName;
            _eyeColour = "brown";
        }

        public Person()
        {

        }

        public override string ToString() // Override which allows us to use the base keyword
        {
            return $"{FirstName} {LastName}"; // This refers to the ToString underneath which is a method made by the object class (hidden class which every class we create inherits)
        }

        public string Move()
        {
            Position += Speed;
            return "Moving along";
        }

        public string Move(int times)
        {
            Position += Speed * times;
            return Move() + $" {times} times";
        }
    }
}