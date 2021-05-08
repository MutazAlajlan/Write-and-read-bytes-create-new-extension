using System;
using System.IO;
using System.Text;

namespace week2Day1
{
    class Program
    {
        public static void createFile(string location, string input)
        {
            if(!File.Exists(location))
            {
                using (FileStream file = File.Create(location))
                {
                    Byte[] content = new UTF32Encoding().GetBytes(input);
                    file.Write(content, 0, content.Length);
                    file.Close();
                }
            }
        }
        public static void readFile (string location)
        {
            string output = "";
           if(File.Exists(location))
            {
                using (StreamReader file = File.OpenText(location))
                {
                    while((output = file.ReadLine())  != null  )
                    {
                        Console.WriteLine(output);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string path = "/Users/rook/Desktop/test.txt";
            string welcome = "Welcome to c#";
            createFile(path, welcome);
            readFile(path);
        }
    }
}
