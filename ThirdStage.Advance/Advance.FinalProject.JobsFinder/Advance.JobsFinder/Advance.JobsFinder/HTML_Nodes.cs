using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.IO;
namespace Advance.JobsFinder
{
    public static class HTML_Nodes
    {
        private const string _name = "//h1[@class='text-left']";
        private const string _skillsDescriptions = "//p[@class='professional-skills-description']";
        private const string _about = "//div[@class='addHeight']";
        private const string _jobs = "//div[@class='job-inner job-item-title']";
        private const string _views = "//span[@class='margin-r-2']";
        public static void CompanySeter(this Company company, string url)
        {
            HtmlDocument document = new HtmlDocument();
            string text = File.ReadAllText(@"" + url);
            document.LoadHtml(text);

            company.CompanyName = document.DocumentNode.SelectSingleNode(_name).InnerText;

            company.Views = Convert.ToInt32(document.DocumentNode.SelectSingleNode(_views).InnerText);

            HtmlNodeCollection skills = document.DocumentNode.SelectNodes(_skillsDescriptions);
            HtmlNodeCollection about = document.DocumentNode.SelectNodes(_about);
            HtmlNodeCollection jobs = document.DocumentNode.SelectNodes(_jobs);
            if (about[0] != null)
                company.CompanyAbout = about[0].InnerText;
            if (about[1] != null)
                company.CompanyAboutMore = about[1].InnerText;
            //Console.WriteLine(about[0].InnerText);
            for (int i = 0; i < skills.Count; i++)
            {
                //Console.WriteLine(skills[i].InnerText);
                if (skills[i].InnerText.Contains("Industry"))
                {
                    string temp = skills[i].InnerText.Substring(skills[i].InnerText.IndexOf(':') + 3);
                    //Console.WriteLine(temp);
                    company.CompanyIndustry = temp;
                }
                else if (skills[i].InnerText.Contains("Type"))
                {
                    string temp = skills[i].InnerText.Substring(skills[i].InnerText.IndexOf(':') + 3);
                    company.CompanyType = temp;
                }
                else if (skills[i].InnerText.Contains("Address"))
                {
                    string temp = skills[i].InnerText.Substring(skills[i].InnerText.IndexOf(':') + 3);
                    company.CompanyAddress = temp;
                }
                else if (skills[i].InnerText.Contains("Website"))
                {
                    string temp = skills[i].InnerText.Substring(skills[i].InnerText.IndexOf(':') + 3);
                    company.CompanyWebsite = temp;
                }
                else if (skills[i].InnerText.Contains("Number of Employees"))
                {
                    string temp = skills[i].InnerText.Substring(skills[i].InnerText.IndexOf(':') + 3);
                    company.NumOfEmployees = temp;
                }
                else if (skills[i].InnerText.Contains("Phone:"))
                {
                    string temp = skills[i].InnerText.Substring(skills[i].InnerText.IndexOf(':') + 3);
                    company.CompanyPhone = temp;
                }
            }

            foreach (var item in jobs)
            {
                company.CompanyJobs.Add(item.InnerText);
                //Console.WriteLine(item.InnerText);
            }
        }
        //margin-r-2

        //foreach (var item in about)
        //{
        //    Console.WriteLine(item.InnerText);
        //}

    }
}
