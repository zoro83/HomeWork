using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy_HomeWork_2
{
    class Carnivore : AnimalBase
    {
        public bool Hunt { get; set; }
        public new string Food { get; } = "meat";

        public Carnivore():base()
        {

        }
    }
}
