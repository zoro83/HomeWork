using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp_Homework_3
{
    class JurassicWorld
    {
        public string Type { get; set; } //Тип
        public string Diet { get; set; } //Питание: Carnivores(Плотоядные), Herbivores(Травоядные), Omnivore(Всеядное)
        public string AgeCategories { get; set; } //baby, young, adult, elder
        public int Damage { get; set; } // 0-10 point
        public int Speed { get; set; } // 0-100 point

        public virtual string Info { get; } = "Dinosaurs are a diverse group of reptiles of the clade Dinosauria";

        public virtual string Characteristic()
        {
            return $"Type: {Type} \nDiet{Diet} \nAgeAgeCategories: {AgeCategories} " +
                $"\nDamage: {Damage} \nSpeed: {Speed} \nInfo{Info}";
        }

        public string DamageLevel(int damage)
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
        public string SpeedLevel(int speed)
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
    }
}
