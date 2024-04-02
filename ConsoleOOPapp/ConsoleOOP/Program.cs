namespace ConsoleOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("John", "Doe", new DateOnly(1989, 8, 4));
            var person2 = new Person("Jane", "Wayne", new DateOnly(1989, 2, 24));

            person1.Pets.Add(new Cat("Nezuko"));
            person2.Pets.Add(new Dog("Coco"));

            List<Person> people = [person1, person2];

            foreach (var person in people)
            {
                Console.WriteLine($"{person}");

                foreach (var pet in person.Pets)
                {
                    Console.WriteLine($"{pet}");
                }
            }
        }
    }
}
