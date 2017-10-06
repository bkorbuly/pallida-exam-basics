using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueCharacter
{
    public class UniqueChar
    {
        
        static public List<char> UniqCharacters(string text)
        {
            var uniqcharlist = new List<char>();
            text = text.ToLower();
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                counter = 0;
                for (int j = 0; j < text.Length; j++)
                {
                    if(text[i] == text[j])
                    {
                        counter++;
                    }
                }
                if(counter ==1)
                {
                    uniqcharlist.Add(text[i]);
                }
            }
            return uniqcharlist;
        }

        static public void PrintOut(List<char> uniqcharlist)
        {
            foreach(Char characters in uniqcharlist)
            {
                Console.Write("\"{0}\", ", characters);
            }
        }
    }
}
