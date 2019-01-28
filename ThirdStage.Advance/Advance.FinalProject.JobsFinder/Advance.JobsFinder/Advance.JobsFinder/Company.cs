using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance.JobsFinder
{
    public class Company
    {
        public string ID { get; set; }
        public string CompanyName { get; set; }
        public string CompanyIndustry { get; set; }
        public string CompanyType { get; set; }
        public string NumOfEmployees { get; set; }
        public int    DateOfFoundation { get; set; }
        public int    ActiveJobsCount { get; set; }
        public string CompanyAbout { get; set; }
        public string CompanyAboutMore { get; set; }
        public string CompanyWebsite { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyLogo { get; set; }
        public int    Views { get; set; }
        public List<ActiveJob> ActiveJobs = new List<ActiveJob>();
        public List<string> CompanyJobs = new List<string>();
        public void AddActiveJob(ActiveJob job)
        {
            ActiveJobs.Add(job);

        }
        public List<ActiveJob> SetActiveJobs()
        {
            return ActiveJobs;

        }
        public Company(string companyName)
        {
            CompanyName = companyName;
        }
        public Company()
        {

        }


    }
}
