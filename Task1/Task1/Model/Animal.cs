using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Model
{
    public class Animal
    {
        public string _gender;
        public string Gender
        {
            get { return _gender; }
            init { _gender = value; }
        }

        public DateTime _birthDate;

        public DateTime BirthDate { get { return _birthDate;} }

        public Animal(string gender)
        {
            _birthDate = DateTime.Now;

            Gender = gender;
        }
    }
}
