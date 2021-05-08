using System;
using System.IO;

namespace createExtension
{
    class Program
    {
        public static void createStudents()
        {
            int magicNumber = 655665;
            string name = "csharp Microsoft";
            string lastname = "Gates";
            int age = 20;

            using (BinaryWriter bw = new BinaryWriter(File.Open("/Users/rook/Desktop/me.bag", FileMode.Create)))
            {
                bw.Write(magicNumber);
                bw.Write(name);
                bw.Write(lastname);
                bw.Write(age);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            createStudents();
        }
    }
}
