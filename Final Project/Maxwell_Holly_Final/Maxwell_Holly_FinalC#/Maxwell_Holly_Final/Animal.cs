using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxwell_Holly_Final
{
    class Animal : Character 
    {
        string _species;
        
        public Animal(string species, string name) : base (name)
        {
            
            _species = species;

        }

        public string Species { get { return _species; } set { _species = value; } }

        public override string Describe()
        {
            string description = $"Hi! I'm {this.Name} and I'm a {this.Species}!\r\n";

            return description;
        }

    }
}
