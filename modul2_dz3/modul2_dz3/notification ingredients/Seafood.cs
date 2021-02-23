using System;
using System.Collections.Generic;
using System.Text;

namespace modul2_dz3.notification
{
    public abstract class Seafood
    {
        public string Name { get; set; }

        public Seafood(string name)
        {
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine($"Seafood {Name}");
        }
    }

    public class Squid : Seafood
    {
        public Squid(string name) : base(name)
        {
        }
    }

    public class Shrimp : Seafood
    {
        public Shrimp(string name) : base(name)
        {

        }
    }
}
