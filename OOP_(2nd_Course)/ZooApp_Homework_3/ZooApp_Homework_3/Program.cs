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

            Dinosaurs dinosaurs = null;
            Console.Write("Dinosaurs names: ");
            string name = Console.ReadLine();
            switch (name)
            {
                case "T-Rex":
                    dinosaurs = t_Rex;
                    break;

                case "Raptor":
                    dinosaurs = raptor;
                    break;

                case "Diplodocid":
                    dinosaurs = diplodocid;
                    break;

                case "Megalodon":
                    dinosaurs = megalodon;
                    break;

                case "Quetzalcoatlus":
                    dinosaurs = quetzalcoatlus;
                    break;

                case "Archaeopteryx":
                    dinosaurs = archaeopteryx;
                    break;

                default:
                    Console.WriteLine("No Result Found");
                    break;
            }
            Console.WriteLine(dinosaurs.Characteristic());



            Console.ReadKey();
        }
    }
}
