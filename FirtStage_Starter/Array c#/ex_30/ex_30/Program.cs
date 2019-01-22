using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_30
{
    class Program
    {

        /*static void FourDigitNumberNoRepeatedDigit()
        {
            for (short num = 1000; num < 9000;)
            {
                bool flag = true;
                byte digitSum = 0;
                byte[] digit = new byte[4];
                byte[] TwoDigit = { (byte)(num % 100), (byte)(num / 100) };
                for (byte i = 0; i < digit.Length; i++)
                {
                    digit[i] = (byte)(num % 10); /// abcd digit[0] = d, ...digit[3] = a
                    num /= 10;
                    digitSum += digit[i];
                }
                if (digit[0] != digit[1] && digit[0] != digit[2] && digit[0] != digit[3] && digit[1] != digit[2] && digit[1] != digit[3] && digit[2] != digit[3] && TwoDigit[1] - TwoDigit[0] == digitSum)
                {
                    Console.WriteLine(num);
                    //Console.WriteLine(digit[0]);
                    //Console.WriteLine(digit[1]);
                    //Console.WriteLine(digit[2]);
                    //Console.WriteLine(digit[3]);
                    //Console.WriteLine(TwoDigit[0]);
                    //Console.WriteLine(TwoDigit[1]);
                }
                else
                    num++;
            }
        }*/

        //// <summary>
        /// Տպում է բոլոր այն քառանիշ թվերը, որոնցում կրկնվող թվանշան չկա և որոնցում առաջին և վերջին երկու թվանշաններից 
        ///կազմված թվերի տարբերությունը հավասար է այդ թվի թվանշանների գումարին։
        /// </summary>
            static void OtherFunction()
            {
                for (byte i = 1; i < 10; i++)
                {
                    for (byte j = 0; j < 10; j++)
                    {
                        for (byte k = 0; k < 10; k++)
                        {
                            for (byte q = 0; q < 10; q++)
                            {
                                byte dif = (byte)(9 * i + 2 * j - 11 * k - 2 * q); 
                                if (i != j && i != k && i != q && j != k && j != q && k != q && dif == 0)
                                {
                                    Console.WriteLine($"{i}{j}{k}{q}");
                                }
                            }
                        }
                    }
                }

            }

        
        static void Main(string[] args)
        {
            OtherFunction();
            Console.ReadKey();
                
        }
    }
}
