using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Advance.JobsFinder
{
    public static class HTML_Nodes
    {
        private const string _companies = "//div[@class=\"company-action company_inner_right\"]";
        private const string _name = "//h1[@class='company-title-views col-lg-10 col-md-10 col-sm-10']"; // text-left
        private const string _skillsDescriptions = "//p[@class='professional-skills-description']";
        private const string _about = "//div[@class='addHeight']";
        private const string _jobs = "//div[@class='job-inner job-item-title']";
        private const string _views = "//span[@class='company-page-views']";//margin-r-2

        public static Company CompanySeter(string url)
        {
            Company company = new Company();
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load(url);
            //string text = File.ReadAllText(@"" + url);
            //document.Load(url);
            //document.LoadHtml(Scroll(url));
            try
            {
                company.CompanyName = document.DocumentNode.SelectSingleNode(_name).InnerText;

                company.Views = Convert.ToInt32(document.DocumentNode.SelectSingleNode(_views).InnerText);
            }
            catch 
            {
            }
            

            HtmlNodeCollection skills = document.DocumentNode.SelectNodes(_skillsDescriptions);
            HtmlNodeCollection about = document.DocumentNode.SelectNodes(_about);
            HtmlNodeCollection jobs = document.DocumentNode.SelectNodes(_jobs);
            HtmlNodeCollection companies = document.DocumentNode.SelectNodes(_companies);
            try
            {
                if (about[0] != null)
                    company.CompanyAbout = about[0].InnerText;
                if (about[1] != null)
                    company.CompanyAboutMore = about[1].InnerText;

            }
            catch (Exception)
            {

                
            }
            
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
            try
            {
                foreach (var item in jobs)
                {
                    company.CompanyJobs.Add(item.InnerText);
                    //Console.WriteLine(item.InnerText);
                }

            }
            catch (Exception)
            {

                
            }
           
            return company;
        }
        public static List<string> SearchCompanies(string url)
        {
            List<string> companiesNames = new List<string>();
            HtmlDocument document = new HtmlDocument();

            //string text = File.ReadAllText(@"" + url);
            document.LoadHtml(Scroll(url));
            HtmlNodeCollection companies = document.DocumentNode.SelectNodes(_companies);
            foreach (var item in companies)
            {
                companiesNames.Add(@"https://staff.am" + item.InnerHtml.Split('"')[1]);
                //Console.WriteLine(item.InnerHtml.Split('"')[1]);
            }
            return companiesNames;
        }
        public static string Scroll(string url)
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--disable-images");
            string directory = @"C:\Users\USER-X\source\repos\ISTC_Coding_School\ThirdStage.Advance\Advance.FinalProject.JobsFinder\Advance.JobsFinder\Advance.JobsFinder\bin\Debug";
            ChromeDriver chromeDriver = new ChromeDriver(directory, chromeOptions);
            chromeDriver.Navigate().GoToUrl(url);

            long scrollHeight = 0;

            do
            {
                IJavaScriptExecutor js = chromeDriver;
                var newScrollHeight = (long)js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight); return document.body.scrollHeight;");

                if (newScrollHeight == scrollHeight)
                {
                    break;
                }
                else
                {
                    scrollHeight = newScrollHeight;
                    Thread.Sleep(2000);
                }
            } while (true);

            return chromeDriver.PageSource;
        }

    }
}
