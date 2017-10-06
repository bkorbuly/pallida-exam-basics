using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavouriteAnimals
{
    class Functions
    {
        static string filename = @"../../../../favourites.txt";
        public static void WriteToFile(List<string> args)
        {
            using (var write = new StreamWriter(filename))
            {
                for (int i = 0; i < args.Count; i++)
                {
                    write.WriteLine(args[i]);
                    Console.WriteLine(args[i]);
                }
            }
        }

        public static void ArgsEmptyorNot(List<string> args)
        {
            if (args.Count == 0)
            {
                Console.WriteLine("C# FavouriteAnimals [animal] [animal]");
            }
            else
            {
                WriteToFile(args);
            }
        }

        public static List<string> DuplicationCheck(string[] args)
        {
            var filteredargs = new List<string>();
            foreach (string arg in args)
            {
                if (!filteredargs.Contains(arg))
                {
                    filteredargs.Add(arg);
                }
            }
            return filteredargs;
        }

        public static void NiceMain(string[] args)
        {
            ArgsEmptyorNot(DuplicationCheck(args));
        }
    }
}
