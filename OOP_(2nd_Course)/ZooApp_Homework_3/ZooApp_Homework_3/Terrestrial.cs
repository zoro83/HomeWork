using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp_Homework_3
{
    class Terrestrial:JurassicWorld
    {
        //can walk on land
        public Terrestrial()
        {
            Type = "Terrestrial";
        }
        public override string Info { get; } = "Terrestrial dinosaurs could walk on land";
    }
}
