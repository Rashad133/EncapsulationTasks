using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Model
{
    public class Dog : Animal
    {
        public string _breed;
        public string Breed
        {
            get { return _breed; }
            init { _breed = value; }

        }

        public string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Dog(string gender , string breed, string name): base(gender)
        {
            Name = name;
            Breed = breed;
        }

    }
}
