using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOf4DigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 4 digit integer number");
            string fourDigitStr;
            int fourDigitNum;
            fourDigitStr = Console.ReadLine();
            
            if (fourDigitStr.Length == 4 || fourDigitStr.Length == 5 && Convert.ToInt32(fourDigitStr)<0) {
                //Console.WriteLine(fourDigitNum.ToCharArray(0, 1));
                //Console.WriteLine(fourDigitNum.ToCharArray(1, 1));
                //Console.WriteLine(fourDigitNum.ToCharArray(2, 1));
                //Console.WriteLine(fourDigitNum.ToCharArray(3, 1));

                fourDigitNum = Convert.ToInt32(fourDigitStr);
                int ind_1 = (fourDigitNum / 1000) % 10;  // bacasakan tveri depqum minus arjeq@ kveragrvi arajin nishin
                int ind_2 = Math.Abs((fourDigitNum / 100) % 10);
                int ind_3 = Math.Abs((fourDigitNum / 10) % 10);
                int ind_4 = Math.Abs(fourDigitNum % 10);
                int indexSum = ind_1 + ind_2 + ind_3 + ind_4;

                Console.WriteLine(indexSum);
            }
            else {
                Console.WriteLine("Incorrect format");
            }
            Console.ReadKey();



        }
    }
}
