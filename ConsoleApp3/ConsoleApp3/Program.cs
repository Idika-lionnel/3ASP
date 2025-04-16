using System;
using System.Collections.Generic;

namespace ConsoleApp3;

class Program
{
    static void Main(string[] args)
    {
        List<Animal> animaux = new List<Animal>
        {
            new Chien("Michou", 7, "Bulldog"),
            new Chat("milou", 2),
            new Chien("rock", 4, "Pitbull"),
            new Chat("didi", 8)
        };

        animaux.Sort();

        foreach (Animal animal in animaux)
        {
            Console.WriteLine(animal.GetInfos());
            Console.WriteLine("Son: " + animal.EmettreSon());
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}