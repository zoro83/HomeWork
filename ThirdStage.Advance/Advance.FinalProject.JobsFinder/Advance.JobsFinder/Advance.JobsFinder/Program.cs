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
            Company company1 = new Company();
            //ActiveJob job1 = new ActiveJob();
            //ActiveJob job2 = new ActiveJob();
            //job1.ActiveJobName = "IT";
            //job1.Data = "2/3/2018";
            //job1.Location = "Yerevan";
            //job2.ActiveJobName = "C#";
            //job2.Data = "10/1/2019";
            //job2.Location = "Yerevan";
            //company1.AddActiveJob(job1);
            //company1.AddActiveJob(job2);
            //foreach (var item in company1.ActiveJobs)
            //{
            //    Console.WriteLine(item.ActiveJobName);
            //    Console.WriteLine(item.Data);
            //    Console.WriteLine(item.Location);
            //}

            //string url = @"C:\Users\USER-X\BetConstruct _ Staff.am";
            //HtmlDocument document = new HtmlDocument();
            //string text = File.ReadAllText(@"C:\Users\USER-X\BetConstruct _ Staff.am.html");
            ////Console.WriteLine(text);
            //document.LoadHtml(text);

            //HtmlNodeCollection selectNodes = document.DocumentNode.SelectNodes("//p[@class='professional-skills-description']");
            ////string innerText = selectSingleNode.InnerText;  //"//div[@class='search_hit']"
            //foreach (var item in selectNodes)
            //{
            //    Console.WriteLine(item.InnerText);
            //}
            ////Console.WriteLine(innerText);
            ///
            string url = @"C:\Users\USER-X\BetConstruct _ Staff.am.html";
            HTML_Nodes.CompanySeter(company1, url);
            Console.WriteLine(company1.CompanyName);
            Console.WriteLine(company1.Industry);
            Console.WriteLine(company1.CompanyType);
            Console.WriteLine(company1.CompanyAddress);
            Console.WriteLine(company1.CompanyWebsite);
            Console.ReadKey();

        }
    }
}
