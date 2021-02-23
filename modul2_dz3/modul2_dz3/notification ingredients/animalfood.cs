using System;
using System.Collections.Generic;
using System.Text;
using modul2_dz3.notification_ingredients;
namespace modul2_dz3.notification
{
    public abstract class Animalfood
    {
        public string Name { get; set; }

        protected Animalfood(string name)
        {
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine($"Animalfood {Name}");
        }
    }

    public class Eggs : Animalfood
    {
        internal int Calories;

        public Eggs(string name) : base(name)
        {
        }
    }
}
