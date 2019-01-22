using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Advance.FileMaker
{
    class Program
    {
        static void WriteFile(string newPath)
        {
            using (StreamWriter sw = File.AppendText(newPath))
            {
                //StreamWriter sw = new StreamWriter(fs);
                Console.WriteLine("Write some text to file");
                string sometext = Console.ReadLine();
                sw.WriteLine(sometext);
            }
        }
        static void ReadFile(string newPath)
        {
            using (FileStream fs = new FileStream(newPath, FileMode.Open, FileAccess.Read))
            {
                StreamReader sr = new StreamReader(fs);
                string allTextByLine = sr.ReadLine();
                Console.WriteLine("All text in file");
                Console.WriteLine(allTextByLine);
            }
        }

        static bool FileChack(string path, string newTxtName)
        {

            bool flag = true;
            foreach (string file in Directory.GetFiles(path))
            {
                if (file == path + newTxtName)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        static void TXTCreator(string path)
        {
            using (FileStream fs = File.Create(path))
            {
                Console.WriteLine("File creat is complete");
                Console.WriteLine("File name: {0}", fs.Name);
                //Console.WriteLine("File Length: {0}", fs.Length);
                //Console.WriteLine("File size: {0}", fs,si);
            }
        }

        static void FileMaker(string path)
        {
            Console.WriteLine("Ther are all existing files");
            foreach (var file in Directory.GetFiles(path))
            {
                Console.WriteLine(file);
            }
            Console.WriteLine("Enter new .txt file name for creating");
            string newTxtName = Console.ReadLine();
            string newPath = path + "\\" + newTxtName + ".txt";
            bool isFileCreat = true;
            if (FileChack(path, newTxtName))
            {
                //Console.WriteLine(path + "\\"+ newTxtName + ".txt");
                TXTCreator(newPath);
            }
            else
            {
                Console.WriteLine("The destination already has a file named: {}", newTxtName + ".txt");
                Console.WriteLine("Replace the file in the destination (Yes/No)");

                string replaceOrSkip = Console.ReadLine();
                if (replaceOrSkip == "yes" || replaceOrSkip == "Yes")
                {
                    TXTCreator(newPath);

                }
                else
                {
                    isFileCreat = false;
                    Console.WriteLine("Start again");
                }
            }
            if (isFileCreat)
            {
                WriteFile(newPath);
            }
            ReadFile(newPath);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Inputh File Path");
            string path = "";
            try
            {
                path = Console.ReadLine();
                FileMaker(path);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();
        }
    }
}
