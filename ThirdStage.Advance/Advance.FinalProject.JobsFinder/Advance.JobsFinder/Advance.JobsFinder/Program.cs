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
        public static void CompanyView(Company company)
        {
            Console.WriteLine("Company Name: {0}", company.CompanyName);
            Console.WriteLine("Company Industry: {0}", company.CompanyIndustry);
            Console.WriteLine("Company Type: {0}", company.CompanyType);
            Console.WriteLine("Company Address: {0}", company.CompanyAddress);
            Console.WriteLine("Company Website: {0}", company.CompanyWebsite);
            Console.WriteLine("Company About: {0}", company.CompanyAbout);
            Console.WriteLine("Company About More: {0}", company.CompanyAboutMore);
            Console.WriteLine("Company Num of Employees: {0}", company.NumOfEmployees);
            Console.WriteLine("Company Phone: {0}", company.CompanyPhone);
            Console.WriteLine("Company Views: {0}", company.Views);
            foreach (var item in company.CompanyJobs)
            {
                Console.WriteLine("Company Active Job: {0}", item);
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string url = @"https://staff.am/en/companies?CompaniesFilter%5BkeyWord%5D=&CompaniesFilter%5Bindustries%5D=&CompaniesFilter%5Bindustries%5D%5B%5D=2&CompaniesFilter%5Bemployees_number%5D=&CompaniesFilter%5Bsort_by%5D=&CompaniesFilter%5Bhas_job%5D=";

            List<string> allCompaniesURL = HTML_Nodes.SearchCompanies(url);
            List<Company> companiesList = new List<Company>();
            foreach (var item in allCompaniesURL)
            {
                companiesList.Add(HTML_Nodes.CompanySeter(item));
            }
            for (int i = 0; i < companiesList.Count; i++)
            {
                CompanyView(companiesList[i]);
            }
            Console.ReadKey();

        }
    }
}
