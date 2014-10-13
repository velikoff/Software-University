using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    public abstract class Animal : ISound
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Genders Gender { get; set; }

        public Animal(string name, int age, Genders gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public abstract void ProduceSound();
    }
}
