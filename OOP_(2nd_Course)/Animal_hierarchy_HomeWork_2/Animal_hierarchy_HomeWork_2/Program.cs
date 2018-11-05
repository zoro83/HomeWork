using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy_HomeWork_2
{
    class Program
    {
        public static void PrintOmnivorCharacteristics(Omnivore omnivore)
        {
            Console.WriteLine($"***  Omnivore characteristics  ***");
            Console.WriteLine($"Legs?: {omnivore.Legs}");
            Console.WriteLine($"Food?: {omnivore.Food}");
            Console.WriteLine($"Hunt?: {omnivore.Hunt}");
            Console.WriteLine($"Scavengers?: {omnivore.Scavengers}");
            Console.WriteLine($"Sexual Reproduction?: {omnivore.SexualReproduction}");
            Console.WriteLine($"Is Able To Move?: {omnivore.IsAbleToMove}");
            Console.WriteLine($"Is Alive?: {omnivore.IsAlive()}");
            Console.WriteLine(new string('*', 25));
        }
        public static void PrintCarnivoreCharacteristics(Carnivore carnivore)
        {
            Console.WriteLine($"***  Carnivore characteristics  ***");
            Console.WriteLine($"Legs?: {carnivore.Legs}");
            Console.WriteLine($"Food?: {carnivore.Food}");
            Console.WriteLine($"Hunt?: {carnivore.Hunt}");
            Console.WriteLine($"Sexual Reproduction?: {carnivore.SexualReproduction}");
            Console.WriteLine($"Is Able To Move?: {carnivore.IsAbleToMove}");
            Console.WriteLine($"Is Alive?: {carnivore.IsAlive()}");
            Console.WriteLine(new string('*', 25));
        }
        public static void PrintHerbivoreCharacteristics(Herbivore herbivore)
        {
            Console.WriteLine($"***  Herbivore characteristics  ***");
            Console.WriteLine($"Legs?: {herbivore.Legs}");
            Console.WriteLine($"Food?: {herbivore.Food}");
            Console.WriteLine($"Gut Flora?: {herbivore.GutFlora}");
            Console.WriteLine($"Sexual Reproduction?: {herbivore.SexualReproduction}");
            Console.WriteLine($"Is Able To Move?: {herbivore.IsAbleToMove}");
            Console.WriteLine($"Is Alive?: {herbivore.IsAlive()}");
            Console.WriteLine(new string('*', 25));
        }
        public static void PrintManCharacteristics(Man man)
        {
            Console.WriteLine($"***  Man characteristics  ***");
            Console.WriteLine($"Legs?: {man.Legs}");
            Console.WriteLine($"Food?: {man.Food}");
            Console.WriteLine($"Hunt?: {man.Hunt}");
            Console.WriteLine($"First Name ?: {man.FirstName}");
            Console.WriteLine($"Last Name ?: {man.lastName}");
            Console.WriteLine($"Is Male ?: {man.IsMale}");
            Console.WriteLine($"Speak ?: {man.Speak()}");
            Console.WriteLine($"Think ?: {man.Think()}");
            Console.WriteLine($"Scavengers?: {man.Scavengers}");
            Console.WriteLine($"Sexual Reproduction?: {man.SexualReproduction}");
            Console.WriteLine($"Is Able To Move?: {man.IsAbleToMove}");
            Console.WriteLine($"Is Alive?: {man.IsAlive()}");
            Console.WriteLine(new string('*', 25));
        }
        public static void PrintLionCharacteristics(Lion lion)
        {
            Console.WriteLine($"***  Lion characteristics  ***");
            Console.WriteLine($"Legs?: {lion.Legs}");
            Console.WriteLine($"Food?: {lion.Food}");
            Console.WriteLine($"Is Male ?: {lion.IsMale}");
            Console.WriteLine($"Weight ?: {lion.Weight}");
            Console.WriteLine($"Age ?: {lion.Age}");
            Console.WriteLine($"Sexual Reproduction?: {lion.SexualReproduction}");
            Console.WriteLine($"Is Able To Move?: {lion.IsAbleToMove}");
            Console.WriteLine($"Is Alive?: {lion.IsAlive()}");
            Console.WriteLine(new string('*', 25));
        }
        public static string WhichIsHavy(Lion lion1, Lion lion2)
        {
            if (lion1.Age == lion2.Age && lion1.IsMale != lion2.IsMale)
            {
                return (lion1.IsMale) ? $"{lion1} is Heavier" : $"{lion2} is Heavier";
            }
            else if (lion1.Age > 2 && lion2.Age > 2 && lion1.IsMale != lion2.IsMale)
            {
                return (lion1.IsMale) ? $"{lion1} is Heavier" : $"{lion2} is Heavier";
            }
            else return "Sorry i can't count";
        }

        static void Main(string[] args)
        {
            AnimalBase animal = new AnimalBase(4, "Somthing else", true, true);
            Omnivore omn = new Omnivore();
            Carnivore car = new Carnivore();
            Herbivore herb = new Herbivore();
            Lion lion1 = new Lion();
            Lion lion2 = new Lion();
            Rabbit rabb = new Rabbit();
            Man man = new Man();
            man.FirstName = "Leo";
            man.lastName = "Leonid";
            man.IsMale = true;
            man.Legs = 2;
            PrintManCharacteristics(man);

            Console.WriteLine($"{animal} is alive: {animal.IsAlive()}");
            Console.WriteLine();
            lion1.Age = 3;
            lion2.Age = 4;
            lion1.IsMale = true;
            lion2.IsMale = false;
            Console.WriteLine(WhichIsHavy(lion1, lion2));
            PrintLionCharacteristics(lion2);
            PrintManCharacteristics(man);
            PrintHerbivoreCharacteristics(herb);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
