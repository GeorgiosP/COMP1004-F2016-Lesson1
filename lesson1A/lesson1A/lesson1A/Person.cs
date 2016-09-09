using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1A
{
    public class Person
    {
        // PRIVATE INSTANCE VARIABLES 
        private string _name;
        private int _age;

        public string Name{
            get {
                return this._name;
            }

            set {
                this._name = value;
            }
        }
        public int Age
        {
            get
            {
                return this._age; 
            }
            set
            {
                this._age = value; 
            }
        }
        // CONSTRUCTORS 
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age; 
        }
        //Public Methods 
        public void SaysHello()
        {
            Console.WriteLine(this.Name + " says hello!");
        }
    }
}
