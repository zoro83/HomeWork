using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp_Homework_3.AerialDynosaurs
{
    class Archaeopteryx : Aerial
    {
        public Archaeopteryx() : base(name: "Archaeopteryx")
        {

        }
        public Archaeopteryx(string diet) : base(name: "Archaeopteryx", diet: diet)
        {

        }
        public Archaeopteryx(string diet, string ageCategories, int damage, int speed)
            : base(name: "Archaeopteryx", diet: diet, ageCategories: ageCategories, damage: damage, speed: speed)
        {

        }
        public override string Info { get; } = "Sorry no info";

    }
}
