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
    }
}
