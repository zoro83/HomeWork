using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp_Homework_3.TerrestialDinosaurs
{
    class Diplodocid : Terrestrial
    {
        public Diplodocid() : base(name: "Diplodocid")
        {

        }
        public Diplodocid(string diet) : base(name: "Diplodocid", diet: diet)
        {

        }
        public Diplodocid(string diet, string ageCategories, int damage, int speed)
            : base(name: "Diplodocid", diet: diet, ageCategories: ageCategories, damage: damage, speed: speed)
        {

        }
        public override string Info { get; } = "Diplodocids were some of the largest creatures ever to walk the Earth " +
            "which may have reached lengths of up to 34 metres ";
    }
}
