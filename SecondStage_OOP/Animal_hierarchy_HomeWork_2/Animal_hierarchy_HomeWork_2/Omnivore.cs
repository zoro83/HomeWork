using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy_HomeWork_2
{
    class Omnivore : AnimalBase
    {
        public bool Hunt { get; set; } //охотник
        public bool Scavengers { get; set; } //мусорщик
        public new string Food { get; } = "Plant and animal origin";
        public Omnivore()
        {

        }
    
        /// <summary>
        /// Returns an Omnivore Like a Carnivore
        /// </summary>
        /// <returns></returns>
        public bool OmnivorelikeCarnivore()
        {
            if (this.Hunt)
            {
                return true;
            }
            else
                return false;
        }
    }
}
