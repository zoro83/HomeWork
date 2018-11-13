using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp_Homework_3
{
    public abstract class Dinosaurs
    {
        public string Type { get; } //Тип
        public string Name { get; } // TiRex, Raptors...Aquatic...
        public string Diet { get; set; } //Питание: Carnivores(Плотоядные), Herbivores(Травоядные), Omnivore(Всеядное)
        public string AgeCategories { get; set; } //Baby,Young, Adult, Elder
        public int Damage { get; set; } // 0-10 point
        public int Speed { get; set; } // 0-100 point
        public virtual string Info { get; } = "Dinosaurs are a diverse group of reptiles of the clade Dinosauria";

        public string Characteristic()
        {
            {
                return $"Type: {Type} \nName: {Name} \nDiet: {Diet} \nAgeAgeCategories: {AgeCategories} " +
                    $"\nDamage: {Damage} \nSpeed: {Speed} \nDamage Level: {DamageLevel()}\nSpeed Level: {SpeedLevel()} \nInfo: {Info}";
            }
        }

        public string DamageLevel()
        {
            if (Damage >= 0 && Damage < 4)
                return "Low";
            if (Damage > 3 && Damage < 7)
                return "Medium";
            if (Damage > 7 && Damage <= 10)
                return "High";
            else
                return "Error";
        }
        public string SpeedLevel()
        {
            if (Speed >= 0 && Speed < 34)
                return "Low";
            if (Speed > 33 && Speed < 67)
                return "Medium";
            if (Speed > 66 && Speed <= 100)
                return "High";
            else
                return "Error";
        }

        public Dinosaurs()
        {

        }
        public Dinosaurs(string type)
        {
            Type = type;
        }
        public Dinosaurs(string type, string name) : this(type)
        {
            Name = name;
        }
        public Dinosaurs(string type, string name, string diet) : this(type: type, name: name)
        {
            Diet = diet;
        }
        public Dinosaurs(string type, string name, string diet, string ageCategories) : this(type, name, diet)
        {
            AgeCategories = ageCategories;
        }
        public Dinosaurs(string type, string name, string diet, string ageCategories, int damage)
            : this(type, name, diet, ageCategories)
        {
            Damage = damage;
        }
        public Dinosaurs(string type, string name, string diet, string ageCategories, int damage, int speed)
            : this(type, name, diet, ageCategories, damage)
        {
            Speed = speed;
        }

    }
}