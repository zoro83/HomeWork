using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnWeekDaysApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input 1-7 numbers to choose Weekend Days");
            double inputNum = Convert.ToDouble(Console.ReadLine());

            string weekendDay;

            switch (inputNum)  // switch i mej kareli er nayev consoli guyner@ 
                              //dnel ev mek switchov cragir@ kavartver
            {
                case 1: //Monday
                    weekendDay = "Monday";
                    break;
                case 2: //Tuesday
                    weekendDay = "Tuesday";
                    break;
                case 3: //Wednesday
                    weekendDay = "Wednesday";
                    break;
                case 4: //Thursday
                    weekendDay = "Thursday";
                    break;
                case 5: //Friday
                    weekendDay = "Friday";
                    break;
                case 6: //Saturday
                    weekendDay = "Saturday";
                    break;
                case 7: //Sunday
                    weekendDay = "Sunday";
                    break;
                default:
                    weekendDay = "Incorrect format";
                    break;
            }

            if (inputNum == 1) //qani vor ham if ham switch operatorner petq e ogtagorcver,
                               //kodi myus mas@ vor@ verabervum er consoli guynerin kgrem if operatorov
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(weekendDay);
            }
            else if (inputNum == 2)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(weekendDay);
            }
            else if (inputNum == 3)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(weekendDay);
            }
            else if (inputNum == 4)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(weekendDay);
            }
            else if (inputNum == 5)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(weekendDay);
            }
            else if (inputNum == 6)
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(weekendDay);
            }
            else if (inputNum == 7)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(weekendDay);
            }
            else {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(weekendDay);
            }

            Console.ResetColor();// stexic heto consoli font@ kdarna default
            //porcenq tar@ mecatar tpel        
            Console.Write("Input any letter: ");
            char anyKey = Convert.ToChar(Console.ReadLine());// anyKey popoxakanin veragrenq mutqagrvac tar@
           
            int anykeyInt = Convert.ToInt32(anyKey) - 32;// anyKey char @ convert anenq ir hamarin ev hanenq 32
            anyKey = Convert.ToChar(anykeyInt); //2 porcic heto parzeci vor mecatari hamar@ 32 ov poqr e 
                                                            //poqratari hamaric
            Console.WriteLine(anyKey);


            Console.ReadKey();
        }
    }
}
