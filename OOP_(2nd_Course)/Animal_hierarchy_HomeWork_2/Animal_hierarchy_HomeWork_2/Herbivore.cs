using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy_HomeWork_2
{
    class Herbivore : AnimalBase
    {
        public new string Food { get; } = "Llants and algae";
        public bool GutFlora { get; set; } = true; // Кишечная флора


    }
}
