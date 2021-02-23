using System;
using System.Collections.Generic;
using System.Text;
using modul2_dz3.notification_ingredients;

namespace modul2_dz3.notification_ingredients
{
    public abstract class Plantfood
    {
        public readonly Ingradients[] _calories;

        public void NotificationCalories()
        {
            Console.WriteLine($"Calories: {_calories}");
        }

        public string Name { get; set; }

        protected Plantfood(string name)
        {
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine($"Plantfood {Name}");
        }
    }

    public class Cabbage : Plantfood
    {
        public Cabbage(string name) : base(name)
        {
        }
    }

    public class Olive : Plantfood
    {
        public Olive(string name) : base(name)
        {
        }
    }
}
