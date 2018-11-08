using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooApp_Homework_3.AerialDynosaurs;
using ZooApp_Homework_3.AquaticDynosaurs;
using ZooApp_Homework_3.TerrestialDinosaurs;

namespace ZooApp_Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //AgeCategories: Baby,Young, Adult, Elder
            //diet(Питание): Carnivores(Плотоядные), Herbivores(Травоядные), Omnivore(Всеядное)
            //Damage 0-10 point
            // Speed 0-100 point
            T_Rex t_Rex = new T_Rex(damage: 9, speed: 33, ageCategories: "Elder", diet: "Carnivores");
            
            Raptor raptor = new Raptor(damage: 7, speed: 88, ageCategories: "Young", diet: "Carnivores");

            Diplodocid diplodocid = new Diplodocid(damage: 1, speed: 13, ageCategories: "Adult", diet: "Herbivores");

            Megalodon megalodon = new Megalodon(damage: 4, speed: 70, ageCategories: "Baby", diet: "Carnivores");

            Quetzalcoatlus quetzalcoatlus = new Quetzalcoatlus(damage: 6, speed: 93, ageCategories: "Adult", diet: "Omnivore");

            Archaeopteryx archaeopteryx = new Archaeopteryx(damage: 6, speed: 93, ageCategories: "Adult", diet: "Omnivore");

            Console.Write("Dinosaurs names: ");
            string name = Console.ReadLine();
            switch (name)
            {
                case "T-Rex":
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Type: {t_Rex.GetDynType()}");
                    Console.WriteLine($"Damage Level: {t_Rex.DamageLevel()}");
                    Console.WriteLine($"Speed Level: {t_Rex.SpeedLevel()}");
                    Console.WriteLine($"{t_Rex.Characteristic()}");
                    Console.ResetColor();
                    break;

                case "Raptor":
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Type: {raptor.GetDynType()}");
                    Console.WriteLine($"Damage Level: {raptor.DamageLevel()}");
                    Console.WriteLine($"Speed Level: {raptor.SpeedLevel()}");
                    Console.WriteLine($"{raptor.Characteristic()}");
                    Console.ResetColor();
                    break;

                case "Diplodocid":
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Type: {diplodocid.GetDynType()}");
                    Console.WriteLine($"Damage Level: {diplodocid.DamageLevel()}");
                    Console.WriteLine($"Speed Level: {diplodocid.SpeedLevel()}");
                    Console.WriteLine($"{diplodocid.Characteristic()}");
                    Console.ResetColor();
                    break;

                case "Megalodon":
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Type: {megalodon.GetDynType()}");
                    Console.WriteLine($"Damage Level: {megalodon.DamageLevel()}");
                    Console.WriteLine($"Speed Level: {megalodon.SpeedLevel()}");
                    Console.WriteLine($"{megalodon.Characteristic()}");
                    Console.ResetColor();
                    break;

                case "Quetzalcoatlus":
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Type: {quetzalcoatlus.GetDynType()}");
                    Console.WriteLine($"Damage Level: {quetzalcoatlus.DamageLevel()}");
                    Console.WriteLine($"Speed Level: {quetzalcoatlus.SpeedLevel()}");
                    Console.WriteLine($"{quetzalcoatlus.Characteristic()}");
                    Console.ResetColor();
                    break;

                case "Archaeopteryx":
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Type: {archaeopteryx.GetDynType()}");
                    Console.WriteLine($"Damage Level: {archaeopteryx.DamageLevel()}");
                    Console.WriteLine($"Speed Level: {archaeopteryx.SpeedLevel()}");
                    Console.WriteLine($"{archaeopteryx.Characteristic()}");
                    Console.ResetColor();
                    break;

                default:
                    Console.WriteLine("No Result Found");
                    break;

            }


            Console.ReadKey();
        }
    }
}
