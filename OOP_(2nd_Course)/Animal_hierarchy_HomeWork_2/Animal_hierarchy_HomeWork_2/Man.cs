using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy_HomeWork_2
{
    class Man : Omnivore
    {
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public bool IsMale { get; set; }
        
        public string Speak()
        {
            return "I can speak !!!";
        }
        public string Think ()
        {
            return "I can think !!!";
        }
    }
}
