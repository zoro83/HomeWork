using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HtmlAgilityPack;

namespace Advance.JobsFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Company company1 = new Company();
            //ActiveJob job1 = new ActiveJob();
            //ActiveJob job2 = new ActiveJob();
            //job1.ActiveJobName = "IT";
            //job1.Data = "2/3/2018";
            //job1.Location = "Yerevan";
            //job2.ActiveJobName = "C#";
            //job2.Data = "10/1/2019";
            //job2.Location = "Yerevan";
   
            string url = @"C:\Users\USER-X\BetConstruct _ Staff.am.html";
            HTML_Nodes.CompanySeter(company1, url);
            Console.WriteLine("Company Name: {0}", company1.CompanyName);
            Console.WriteLine("Company Industry: {0}", company1.CompanyIndustry);
            Console.WriteLine("Company Type: {0}", company1.CompanyType);
            Console.WriteLine("Company Address: {0}", company1.CompanyAddress);
            Console.WriteLine("Company Website: {0}", company1.CompanyWebsite);
            Console.WriteLine("Company About: {0}", company1.CompanyAbout);
            Console.WriteLine("Company About More: {0}", company1.CompanyAboutMore);
            Console.WriteLine("Company Num of Employees: {0}", company1.NumOfEmployees);
            Console.WriteLine("Company Phone: {0}", company1.CompanyPhone);
            Console.WriteLine("Company Views: {0}", company1.Views);
            foreach (var item in company1.CompanyJobs)
            {
                Console.WriteLine("Company Active Job: {0}", item);
            }
            Console.ReadKey();

        }
    }
}
