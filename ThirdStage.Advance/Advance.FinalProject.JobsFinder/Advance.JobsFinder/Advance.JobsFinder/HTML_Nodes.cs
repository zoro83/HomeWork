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
        public static void CompanySeter(this Company company, string url)
        {
            HtmlDocument document = new HtmlDocument();
            string text = File.ReadAllText(@""+url);
            document.LoadHtml(text);

            company.CompanyName = document.DocumentNode.SelectSingleNode(_name).InnerText;

            HtmlNodeCollection skills = document.DocumentNode.SelectNodes(_skillsDescriptions);
            for (int i = 0; i < skills.Count; i++)
            {
                //Console.WriteLine(skills[i].InnerText);
                if (skills[i].InnerText.Contains("Industry"))
                {
                    string temp = skills[i].InnerText.Substring(skills[i].InnerText.IndexOf(':')+3);
                    //Console.WriteLine(temp);
                    company.Industry = temp;
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
            }
            
        }
    }
}
