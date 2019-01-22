using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// This one concerns a person
    /// </summary>
    public class Human
    {
        string firstName;
        string lastName;
        string sex;
        int age;
        int weight;
        int height;

        public void PrintFirstname()
        {
            Console.WriteLine($"First Name: {firstName}");
        }
        public void PrintLastname()
        {
            Console.WriteLine($"Last Name: {lastName}");
        }
        public void PrintSex()
        {
            Console.WriteLine($"Sex: {sex}");
        }
        public void PrintAge()
        {
            Console.WriteLine($"Age: {age}");
        }
        public void PrintWeight()
        {
            Console.WriteLine($"Weight(kg): {weight}");
        }
        public void PrintHeight()
        {
            Console.WriteLine($"Height(cm): {height}");
        }
        public void PrintAllAboutPerson()
        {
            Console.WriteLine("*** All About person ***");
            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Sex: {sex}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Weight(kg): {weight}");
            Console.WriteLine($"Height(cm): {height}");
            Console.WriteLine("******************");
        }
        public Human()
        {
            this.firstName = "";
            this.lastName = "";
            this.sex = "";
            this.age = 0;
            this.weight = 0;
            this.height = 0;
        }

        public Human(string first_N, string last_N, string maleOrfemele)
        {
            firstName = first_N;
            lastName = last_N;
            sex = maleOrfemele;
            age = 0;
            weight = 0;
            height = 0;
        }
        public Human(int years, int kg, int cm)
        {
            firstName = "";
            lastName = "";
            sex = "";
            this.age = years;
            this.weight = kg;
            this.height = cm;
        }

        public Human(string first_N, string last_N, string maleOrfemele, int years, int kg, int cm)
        {
            this.firstName = first_N;
            this.lastName = last_N;
            this.sex = maleOrfemele;
            this.age = years;
            this.weight = kg;
            this.height = cm;
        }
        public void SetFirstName(string first_n)
        {
            firstName = first_n;
        }
        public void SetLastName(string last_n)
        {
            lastName = last_n;
        }
        public void SetSex(string maleOrfemele)
        {
            sex = maleOrfemele;
        }
        public void SetAge(int years)
        {
            age = years;
        }
        public void SetWeight(int kg)
        {
            weight = kg;
        }
        public void SetHeight(int cm)
        {
            height = cm;
        }
        public void SetFirstLastNameAndSex(string first_N, string last_N, string maleOrfemele)
        {
            this.firstName = first_N;
            this.lastName = last_N;
            this.sex = maleOrfemele;
        }
        public void SetAgeWeightHeight(int years, int kg, int cm)
        {
            this.age = years;
            this.weight = kg;
            this.height = cm;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human();
            Human human2 = new Human("Johnnie", "Matthes", "Male");
            Human human3 = new Human("Cecila", "Vandoren", "Female", 27, 67, 167);
            
            human1.PrintAllAboutPerson();
            human2.PrintAllAboutPerson();
            human3.PrintAllAboutPerson();
            human1.SetFirstName("Junior");
            human1.SetLastName("Banas");
            human1.SetAge(55);
            human1.SetHeight(159);
            human1.PrintFirstname();
            human1.PrintLastname();
            human3.SetAge(33);
            human3.SetHeight(164);
            human3.PrintAllAboutPerson();
            human2.SetAgeWeightHeight(22, 77, 188);
            human2.PrintAllAboutPerson();
            human3.SetFirstLastNameAndSex("Cristin", "Shutts", "Female");
            human3.PrintAllAboutPerson();

            Console.ReadKey();
        }
    }
}
