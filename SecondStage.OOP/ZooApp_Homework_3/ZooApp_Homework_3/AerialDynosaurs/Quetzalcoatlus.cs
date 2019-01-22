using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp_Homework_3.AerialDynosaurs
{
    class Quetzalcoatlus : Aerial
    {
        public Quetzalcoatlus() : base(name: "Quetzalcoatlus")
        {

        }
        public Quetzalcoatlus(string diet) : base(name: "Quetzalcoatlus", diet: diet)
        {

        }
        public Quetzalcoatlus(string diet, string ageCategories, int damage, int speed)
            : base(name: "Quetzalcoatlus", diet: diet, ageCategories: ageCategories, damage: damage, speed: speed)
        {

        }
        public override string Info { get; } = "Its wingspan is 10-11 meters";
    }
}
