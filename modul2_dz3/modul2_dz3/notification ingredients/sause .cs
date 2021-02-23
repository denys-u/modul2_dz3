using System;
using System.Collections.Generic;
using System.Text;

namespace modul2_dz3.notification_ingredients
{
    public abstract class Sause
    {
        public string Name { get; set; }

        public Sause(string name)
        {
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine($"Sause {Name}");
        }
    }

    public class Pepper : Sause
    {
        public Pepper(string name) : base(name)
        {
        }
    }

    public class Salt : Sause
    {
        public Salt(string name) : base(name)
        {
        }
    }

    public class Oil : Sause
    {
        public Oil(string name) : base(name)
        {
        }
    }

    public class Mustard : Sause
    {
        public Mustard(string name) : base(name)
        {
        }
    }
}
