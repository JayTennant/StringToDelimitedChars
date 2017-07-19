using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToCommaChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";

            while(result.ToLower() != "exit")
            {
                Console.WriteLine("\nType in a string to convert to comma-delimited chars (type 'exit' to quit):");
                result = Console.ReadLine();
                Console.Write("Size: ");
                Console.WriteLine(result.Length + 1);

                Console.WriteLine("As chars:");
                for (int i = 0; i < result.Length; i++)
                {
                    Console.Write("'");
                    Console.Write(result[i]);
                    Console.Write("',");
                }
                Console.WriteLine("0,");

                Console.WriteLine("As decimal:");
                for (int i = 0; i < result.Length; i++)
                {
                    Console.Write((uint)result[i]);
                    Console.Write(",");
                }
                Console.WriteLine("0,");
            }

            Console.WriteLine("\nPress any key to quit...");
            Console.ReadKey();
        }
    }
}
