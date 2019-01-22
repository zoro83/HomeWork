using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_29
{
    class Program
    {
        //Խնդիր_29:
        //Եռանիշ թվի առաջին թվանշանը ջնջել։ Եթե ստացված թիվը բազմապատկվի 7-ով, կստացվի սկզբնական թիվը։ 
        //Գտնել այդպիսի թվերը,  
        //քանի որ այս խնդրի լուծումը առանց մասիվների ավելի կարճ է, նոր կոդ չեմ գրում:
        static int Remove1stDigit(int n)
        {

            int result = n % 100;
            //Console.WriteLine(result);
            return result;
        }
        static void Main(string[] args)
        {
            for (int i = 100; i < 1000; i++)
            {
                if (i == 7 * Remove1stDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
