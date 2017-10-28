using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            //s pylen pat
            byte[] bytes = 
            File.ReadAllBytes(@"D:\Programming Fundamentals - Extended\06. Programming-Fundamentals-Arrays.pptx");
            Console.WriteLine(bytes);
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = (byte) (bytes[i] + 1);

            }
            File.WriteAllBytes(@"C:\Temp\decrypted.pptx", bytes);
        }
    }
}
