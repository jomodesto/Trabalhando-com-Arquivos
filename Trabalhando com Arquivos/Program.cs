using System;
using System.IO;

namespace Trabalhando_com_Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\File\File1.txt";
            string targetPath = @"c:\File\File2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
            catch(IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
