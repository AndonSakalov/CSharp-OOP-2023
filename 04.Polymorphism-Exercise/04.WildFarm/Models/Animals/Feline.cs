﻿using _04.WildFarm.Models.Interfaces;

namespace _04.WildFarm.Models.Animals
{
    public abstract class Feline : Mammal, IFeline
    {
        public Feline(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion)
        {
            Breed = breed;
        }

        public string Breed { get; private set; }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";

        }
    }
}
