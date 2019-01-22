using System;
using ZooApp_Homework_3.AquaticDynosaurs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp_Homework_3.AquaticDynosaurs
{
    class Megalodon : Aquatic
    {
        public Megalodon() : base(name: "Megalodon")
        {

        }
        public Megalodon(string diet) : base(name: "Megalodon", diet: diet)
        {

        }
        public Megalodon(string diet, string ageCategories, int damage, int speed)
            : base(name: "Megalodon", diet: diet, ageCategories: ageCategories, damage: damage, speed: speed)
        {

        }

        public override string Info { get; } = "Megalodon meaning big tooth it reached a length of 18 meters";

    }
}
