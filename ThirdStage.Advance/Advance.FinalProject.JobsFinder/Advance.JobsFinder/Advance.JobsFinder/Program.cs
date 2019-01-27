using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance.JobsFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            ActiveJob activeJob = new ActiveJob();
            activeJob.AddActiveJob("IT");
            activeJob.AddActiveJob("C#");
            foreach (var item in activeJob.ActiveJobs)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
