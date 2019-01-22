using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_30
{
    class Program
    {
        static short FourDigitNumberNoDigitRepeat(short num)             
            {
            short[] digit = new short[4];
            short[] twoDigit = { (short)(num / 100), (short)(num % 100) };
            short digitSum = 0;
            for (short i = 0; i < 4; i++)
            {
                digit[i] = (short)(num % 10);
                num /= 10;
                digitSum += digit[i];
            }
            
            }
        static void Main(string[] args)
        {
        }
    }
}
