using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<IAnimal> animals = new List<IAnimal>
        {

            new Dog(),
            new Cat(),
            new Bird(),
            new Cow()
        };

        foreach (var animal in animals)
        {
            Console.WriteLine($"{animal.GetType().Name} make sounds: {animal.ProduceSound()}");
        }
    }
}
