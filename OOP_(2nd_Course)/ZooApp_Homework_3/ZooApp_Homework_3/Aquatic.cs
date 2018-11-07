using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp_Homework_3
{
    class Aquatic:JurassicWorld
    {

        public Aquatic()
        {
            Type = "Aquatic";
        }
        public override string Info { get; } = "Aquatic dinosaurs lived in the water for most or all of its lifetime";

    }
}
