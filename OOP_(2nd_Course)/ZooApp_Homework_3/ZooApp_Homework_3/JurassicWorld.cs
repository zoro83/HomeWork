using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp_Homework_3
{
    class JurassicWorld
    {
        private string type; //Тип
        private string name; // TiRex, Raptors...Aquatic...
        private string diet; //Питание: Carnivores(Плотоядные), Herbivores(Травоядные), Omnivore(Всеядное)
        
        static public string AgeCategories { get; set; } //Baby,Young, Adult, Elder
        static public int Damage { get; set; } // 0-10 point
        static public int Speed { get; set; } // 0-100 point

        public virtual string Info { get; } = "Dinosaurs are a diverse group of reptiles of the clade Dinosauria";

        public string Characteristic()
        {
            return $"Diet: {diet} \nName: {name} \nAgeAgeCategories: {AgeCategories} " +
                $"\nDamage: {Damage} \nSpeed: {Speed} \nInfo: {Info}";
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
        public string GetDynType()
        {
            return type;
        }
        public JurassicWorld()
        {

        }
        public JurassicWorld(string type)
        {
            this.type = type;
        }
        public JurassicWorld(string type, string name) : this(type)
        {
            this.name = name;
        }
        public JurassicWorld(string type, string name, string diet) : this(type: type, name: name)
        {
            this.diet = diet;
        }
        public JurassicWorld(string type, string name, string diet, string ageCategories) : this(type, name, diet)
        {
            AgeCategories = ageCategories;
        }
        public JurassicWorld(string type, string name, string diet, string ageCategories, int damage)
            : this(type, name, diet, ageCategories)
        {
            Damage = damage;
        }
        public JurassicWorld(string type, string name, string diet, string ageCategories, int damage, int speed)
            : this(type, name, diet, ageCategories, damage)
        {
            Speed = speed;
        }

    }
}