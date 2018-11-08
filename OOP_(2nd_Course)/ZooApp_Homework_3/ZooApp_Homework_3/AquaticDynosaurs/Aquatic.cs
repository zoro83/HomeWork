using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp_Homework_3.AquaticDynosaurs
{
    class Aquatic : JurassicWorld
    {
        public Aquatic() : base(type: "Aquatic")
        {

        }
        public Aquatic(string name) : base(type: "Aquatic", name: name)
        {

        }
        public Aquatic(string name, string diet) : base(type: "Aquatic", name: name, diet: diet)
        {

        }
        public Aquatic(string name, string diet, string ageCategories, int damage, int speed)
            : base(type: "Aquatic", name: name, diet: diet, ageCategories:
                        ageCategories, damage: damage, speed: speed)
        {

        }
        public override string Info { get; } = "Aquatic dinosaurs lived in the water for most or all of its lifetime";

    }
}
