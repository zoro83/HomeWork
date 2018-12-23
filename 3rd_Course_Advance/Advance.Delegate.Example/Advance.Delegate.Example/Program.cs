using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance.Delegate.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var anonymousFunctions = new List<Action>();
            var listOfNumbers = Enumerable.Range(0, 10);

            // 10, 10, 10
            for (int forLoopVariable = 0; forLoopVariable < 10; forLoopVariable++)
            {
                anonymousFunctions.Add(delegate { Console.WriteLine(forLoopVariable); });
            }

            foreach (Action writer in anonymousFunctions)
            {
                writer();
            }

            anonymousFunctions.Clear();

            // 0, 1, 2 ....

            foreach (var i in listOfNumbers)
            {
                anonymousFunctions.Add(delegate { Console.WriteLine(i); });
            }

            foreach (Action writer in anonymousFunctions)
            {
                writer();
            }
            int k = 7;
            for (k = 0; k < 10; k++)
            {
            }
            Console.WriteLine(k); // output 10
            Console.Read();
        }
    }
}
