using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOOP
{
    // Base Class Abstract(Blueprint)
    public abstract class Pet(string firstName)
    {
        public string First { get; } = firstName;
        // Abstract to reserve a slot for a behavior implementation on child classes
        public abstract string MakeNoise();

        public override string ToString()
        {
            return $"{MakeNoise()}! I am {firstName} and I am a {GetType().Name}";
        }
    }

    // Child Classes from Parent (Pet)
    public class Dog(string firstName) : Pet(firstName)
    {
        public override string MakeNoise() => "Woof";
        
    }

    public class Cat(string firstName) : Pet(firstName)
    {
        public override string MakeNoise() => "Meow";
    }
}
