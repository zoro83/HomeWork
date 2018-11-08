using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp_Homework_3.AerialDynosaurs
{
    class Aerial:JurassicWorld
    {
        public Aerial() : base(type: "Aerial")
        {

        }
        public Aerial(string name) : base(type: "Aerial", name: name)
        {

        }
        public Aerial(string name, string diet) : base(type: "Aerial", name: name, diet: diet)
        {

        }
        public Aerial(string name, string diet, string ageCategories, int damage, int speed)
            : base(type: "Aerial", name: name, diet: diet, ageCategories:
                        ageCategories, damage: damage, speed: speed)
        {

        }
        public override string Info { get; } = "Aerial dinosaurs could flight";
     
    }
}
