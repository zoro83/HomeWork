using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp_Homework_3
{
    class Aerial:JurassicWorld
    {
        public Aerial()
        {
            Type = "Aerial";
        }
        public override string Info { get; } = "Aerial dinosaurs could flight";
     
    }
}
