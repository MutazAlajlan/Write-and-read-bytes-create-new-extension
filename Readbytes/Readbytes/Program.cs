using System;
using System.IO;

namespace Readbytes
{
    class Program
    {
        public static void printBytes(string printString, int num)
        {

            //byte[] bytArray;
            //string output = printString + " ";
            //string location = "/Users/rook/Desktop/t.png";
            //using (BinaryReader reader = new BinaryReader(File.Open(location, FileMode.Open)))
            //{
            //    //Console.Write("The PNG file signature is: ");
            //    for (int i = 0; i < num; i++)
            //    {


            //        //Console.Write(reader.ReadByte() + " ");
            //        output += reader.ReadByte() + " ";
            //    }
            //    //Console.Write(reader.ReadByte() + " ");

            //    output += "\n";
            //    Console.Write(output);
            //}
        }
        static void Main(string[] args)
        {
            //Console.Write("The PNG file signature is: ");

            string output = "";
            string location = "/Users/rook/Desktop/t.png";
            using (BinaryReader reader = new BinaryReader(File.Open(location, FileMode.Open)))
            {
                Console.Write("The PNG file signature is: ");
                for (int i = 0; i < 8; i++)
                {


                    //Console.Write(reader.ReadByte() + " ");
                    output += reader.ReadByte() + " ";
                }
                //Console.Write(reader.ReadByte() + " ");

                output += "\n";
                Console.Write(output);
                output = "IHDR: ";
                for(int i = 0; i < 8; i++)
                {
                    output += reader.ReadByte() + " ";
                }
               
                output += "\n";
                output += "The width: ";
                string convert = "";
                for (int i = 0; i < 4; i++)
                {
                    output += reader.ReadByte() + " ";
                }
                Console.Write(output);
                output = "";
                output += "\n";
                output += "The hight: ";
                for (int i = 0; i < 4; i++)
                {
                    output += reader.ReadByte() + " ";
                }
                Console.Write(output);
            }
            //printBytes("The PNG file signature is: ", 8);

            //printBytes("The width is: ", 4);

        }
    }
}
