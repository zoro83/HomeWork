using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp_Homework_3.TerrestialDinosaurs
{
    class Terrestrial : Dinosaurs
    {
        //can walk on land
        public Terrestrial() : base(type: "Terrestrial")
        {

        }
        public Terrestrial(string name) : base(type: "Terrestrial", name: name)
        {

        }
        public Terrestrial(string name, string diet) : base(type: "Terrestrial", name: name, diet: diet)
        {

        }
        public Terrestrial(string name, string diet, string ageCategories, int damage, int speed)
            : base(type: "Terrestrial", name: name, diet: diet, ageCategories: ageCategories, damage: damage, speed: speed)
        {

        }
        public override string Info { get; } = "Terrestrial dinosaurs could walk on land";

       
    }
}
