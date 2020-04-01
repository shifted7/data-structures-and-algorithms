using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class AnimalShelter
    {
        public Animal Front { get; set; }
        public Animal Rear { get; set; }
        Animal Current { get; set; }
        
        /// <summary>
        /// Adds the given animal to the end of the line of the animal shelter.
        /// </summary>
        /// <param name="animal">The Animal object to enqueue at the end of the line.</param>
        /// <returns>The enqueued Animal.</returns>
        public Animal Enqueue(Animal animal)
        {
            if (IsEmpty())
            {
                Front = animal;
                Current = animal;
                Rear = animal;
                return Rear;
            }
            Rear.Next = animal;
            Rear = animal;
            return Rear;
        }

        /// <summary>
        /// Removes from the shelter and returns the first animal in line that matches the given preference of species.
        /// </summary>
        /// <param name="Preference">The preferred species of animal to dequeue (currently only dog or cat).</param>
        /// <returns>The Animal object of the chosen animal, or null if the preferred species is not found.</returns>
        public Animal Dequeue(string Preference)
        {
            if (IsEmpty())
            {
                throw new Exception("Cannot dequeue animal from empty animal shelter.");
            }
            Animal chosenAnimal = null;
            Animal previousAnimal = null;
            while (Current != null) // Loop until end of line.
            {
                if (Current.Species.ToLower() == Preference.ToLower()) // Case: Match to preference found. Handle chosen animal and break loop.
                {
                    chosenAnimal = Current;
                    if(Current == Front) // Case: matching animal is first in line. Change front of line to next animal.
                    {
                        Front = Front.Next;
                    }
                    else // Case: matching animal is not first in line. 
                    {
                        previousAnimal.Next = Current.Next; // Reset the previous animal to skip the current animal and go to the next animal in line, removing the current animal from the line.
                    }
                    chosenAnimal.Next = null; // Cut the chosen animal's connection to the animal next in line, to remove it fully from the shelter.
                    break;
                }
                previousAnimal = Current; // Case: match to preference not yet found.
                Current = Current.Next; 
            }
            Current = Front; // Reset Current to Front
            return chosenAnimal; // Returns a cat or dog if found, otherwise null.
        }

        public bool IsEmpty()
        {
            return Front == null;
        }
    }
}
