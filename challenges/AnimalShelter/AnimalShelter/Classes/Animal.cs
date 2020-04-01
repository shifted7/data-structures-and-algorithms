using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public Animal Next { get; set; }
        public Animal(string name, string dogOrCat)
        {
            Name = name;
            Species = dogOrCat;
        }
    }
}
