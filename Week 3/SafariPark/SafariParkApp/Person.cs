using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class Person
    {
        //fields
        private string _firstName = "";
        private string _lastName = "";

        //property
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
        public string FullName()
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
        }

        public Person()
        {

        }
    }
}