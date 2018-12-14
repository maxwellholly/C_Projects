using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxwell_Holly_Final
{
    class Character
    {
        //Encapsulation using private designation
        private string _name;

        public Character() { }

        public Character(string name)
        {

            _name = name;


        }

        public string Name { get { return _name; } set { _name = value; } }

        //Virtual method for polymorphism (will override in child class Animal)
        public virtual string Describe()
        {
            string description = $"{this.Name} is now the main character in this story!";

            return description;
        }


    }
}
