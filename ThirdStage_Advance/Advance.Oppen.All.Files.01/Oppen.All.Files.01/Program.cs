using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Oppen.All.Files._01
{
    class Program
    {
        static void DirSearch(string dirName)
        {
            try
            {
                foreach (string dir in Directory.GetDirectories(dirName))
                {
                    if (Directory.GetFiles(dirName) != null)
                    {
                        foreach (string file in Directory.GetFiles(dir))
                        {
                            Console.WriteLine(file);
                        }
                    }

                    DirSearch(dir);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
       
        static void Main(string[] args)
        {
            string dirName = "C:\\";


            string[] fileList = Directory.GetFiles(dirName);
            string[] dirList = Directory.GetDirectories(dirName);
            foreach (var item in fileList)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < dirList.Length; i++)
            {
                dirName = dirList[i];

                DirSearch(dirName);

            }

            Console.ReadKey();
        }
    }
}
