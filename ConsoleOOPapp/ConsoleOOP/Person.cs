using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOOP
{
    public class Person
    {
        // Private fields
        private string firstName;
        private string lastName;
        private DateOnly birthDate;

        // constructor (same name as Class)
        public Person(string first, string last, DateOnly bd)
        {
            // Assign values to private fields
            this.First = first;
            this.Last = last;
            this.BirthDate = bd;
        }

        // Public properties
        public string First { get; }
        public string Last { get; }
        public DateOnly BirthDate { get; }

        public List<Pet> Pets { get; } = new();

        public override string ToString()
        {
            return $"Hi, I am {First} {Last} and this is my pet..";
        }
    }
}
