using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy_HomeWork_2
{
    class AnimalBase
    {
        public int Legs { get; set; }
        public string Food { get; set; }
        public bool SexualReproduction { get; set; } = true;
        public bool IsAbleToMove { get; set; } = true;

        public bool IsAlive()
        {
            if (this.SexualReproduction || this.IsAbleToMove)
            {
                return true;
            }
            else
                return false;
        }
        public AnimalBase()
        {

        }
        public AnimalBase(int Legs, string Food, bool SexualReproduction, bool IsAbleToMove)
        {
            this.Legs = Legs;
            this.Food = Food;
            this.SexualReproduction = SexualReproduction;
            this.IsAbleToMove = IsAbleToMove;
        }

    }
}
