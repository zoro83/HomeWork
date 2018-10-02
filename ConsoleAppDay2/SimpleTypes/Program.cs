using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName;
            string LastName;
            short age;
            short current_year;
            double weight;
            double height;
            sbyte male_female;
            
            Console.Write("Please enter Your First Name: ");
            FirstName = Console.ReadLine();

            Console.Write("Please enter Your Last Name: ");
            LastName = Console.ReadLine();

            Console.Write("Please enter your year of birth: ");
            age = Convert.ToInt16(Console.ReadLine());

            Console.Write("Please enter your weight(kg): ");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter your height(m): ");
            height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter 1 if you ara Male or -1 if you are Female: ");
            male_female = Convert.ToSByte(Console.ReadLine());


            current_year = Convert.ToInt16(DateTime.Now.Year); //DateTime.Now.Year returns int 
                                                               //that`s we need to convert to short
            age = (short)(current_year - age); // tariq@ chisht khashvi nayev 2018 ic heto


            Console.WriteLine("Hi {0} {1}", FirstName, LastName);
            Console.WriteLine("You are {0} years old", age);
            Console.WriteLine("Your weight is {0}kg and your height is {1}m", weight, height);
            if (male_female == 1)
            {
                Console.WriteLine("You ara Male");
            }
            else {
                Console.WriteLine("You ara Female");
            }
                      
            Console.ReadKey();
        }
    }
}
