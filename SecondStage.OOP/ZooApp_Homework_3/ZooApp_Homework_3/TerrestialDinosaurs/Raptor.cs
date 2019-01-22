using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp_Homework_3.TerrestialDinosaurs
{
    class Raptor : Terrestrial
    {
        public Raptor() : base(name: "Raptor")
        {

        }
        public Raptor(string diet) : base(name: "Raptor", diet: diet)
        {

        }
        public Raptor(string diet, string ageCategories, int damage, int speed)
            : base(name: "Raptor", diet: diet, ageCategories: ageCategories, damage: damage, speed: speed)
        {

        }
        public override string Info { get; } = "Velociraptor(Raptor) was roughly the size of a turkey, " +
            "0.5 m tall and 15 kg reptiles.";
    }
}
