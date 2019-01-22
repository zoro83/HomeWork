using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Advance.Oppen.All.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            /*Получим имена и свойства всех дисков на компьютере
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine("Название: {0}", drive.Name);
                Console.WriteLine("Тип: {0}", drive.DriveType);
                if (drive.IsReady)
                {
                    Console.WriteLine("Объем диска: {0}", drive.TotalSize);
                    Console.WriteLine("Свободное пространство: {0}", drive.TotalFreeSpace);
                    Console.WriteLine("Метка: {0}", drive.VolumeLabel);
                }
                Console.WriteLine();
            } */
            string dirName = "C:\\";

            if (Directory.Exists(dirName))
            {
                Console.WriteLine("All Files in My Computer");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string item in dirs)
                {
                    Console.WriteLine(item);
                    try
                    {
                        string[] subDir1 = Directory.GetDirectories(item);

                        foreach (string item1 in subDir1)
                        {
                            Console.WriteLine(item1);

                            string[] subDir2 = Directory.GetDirectories(item1);
                            try
                            {
                                foreach (var item2 in subDir2)
                                {
                                    Console.WriteLine(item2);
                                }
                            }
                            catch { }
                        }
                    }
                    catch { }
                   

                }
                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadLine();
        }
    }
}
