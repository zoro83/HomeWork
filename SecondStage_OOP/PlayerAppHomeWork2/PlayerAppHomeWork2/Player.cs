using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerAppHomeWork2
{
    class Player
    {
        private string possition;
        private int born;

        public string FirstName { set; get; }
        public string LastName { set; get; }
        public int Born
        {
            set
            {
                born = value;
            }
        }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - born;
            }
        }
        public int Height { set; get; }
        public int Weight { set; get; }
        public int ShirtNumber { set; get; }
        public string Nationality { set; get; }
        public string Club { set; get; }
        public string Possition
        {
            set
            {
                if (value == "FORWARD" || value == "Forward" || value == "forward")
                {
                    possition = "FORWARD";
                }
                else if (value == "MIDFIELDER" || value == "Midfielder" || value == "midfielder")
                {
                    possition = "MIDFIELDER";
                }
                else if (value == "DEFENDER" || value == "Defender" || value == "defender")
                {
                    possition = "DEFENDER";
                }
                else if (value == "GOALKEEPER" || value == "Goalkeeper" || value == "goalkeeper")
                {
                    possition = "GOALKEEPER";
                }

                else
                {
                    possition = "Undefined";
                }
            }
            get
            {
                return possition;
            }
        }

    }
}
