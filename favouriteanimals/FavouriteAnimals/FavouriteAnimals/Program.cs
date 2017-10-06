using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavouriteAnimals
{
    class Program
    {
        static string filename = @"../../../../favourites.txt";
        static void Main(string[] args)
        {
            ArgsEmptyorNot(args);
            Console.ReadLine();
        }

        public static void WriteToFile(string[] args)
        {
            using (var write = new StreamWriter(filename))
            {
                for (int i = 0; i < args.Length; i++)
                {
                    write.WriteLine(args[i]);
                    Console.WriteLine(args[i]);
                }
            }
        }

        public static void ArgsEmptyorNot(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("C# FavouriteAnimals [animal] [animal]");
            }
            else
            {
                WriteToFile(args);
            }
        }
    }
}
