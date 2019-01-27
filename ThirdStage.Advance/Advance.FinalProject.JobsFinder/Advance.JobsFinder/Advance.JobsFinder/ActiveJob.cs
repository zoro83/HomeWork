using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance.JobsFinder
{
    public class ActiveJob
    {
        //List<string> activeJob = new List<string>();
        public List<string> ActiveJobs = new List<string>();
        public void AddActiveJob(string job)
        {
            ActiveJobs.Add(job);

        }
        public List<string> SetActiveJobs(string job)
        {
            return ActiveJobs;

        }
    }
}
