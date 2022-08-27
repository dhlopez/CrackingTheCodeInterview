using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrackingTheCodeInterviewChapter1._1._1
{
    //Implement an algorithm to determine if a string has all unique characters.What if you can not use additional data structures?
    public class FindIfUniqueCharacters
    {
        //private string phrase;

        //public string Phrase { get; set; }

        public FindIfUniqueCharacters()///string phrase)
        {
           // Phrase = phrase;
        }

        public bool IsUniqueCharactersOnly(string phrase)
        {
            List<char> phraseByChar = phrase.ToList();

            foreach (var c in phraseByChar)
            {

                if (phraseByChar.Select(x => x.ToString()).Where(x=>x==c.ToString()).Count() > 1)
                {
                    Console.WriteLine("Duplicated value {0}", c.ToString());
                    return false;
                }
            }

            return true;
        }

        public bool IsUniqueCharactersOnlyNoDataStructure(string phrase)
        { 
            foreach(var c in phrase)
            {
                int instances = 0;

                for (int i = 0; i< phrase.Length; i++)
                {
                    if (phrase[i].Equals(c))
                    {
                        instances++;
                        if (instances > 1)
                        { return false; }
                    }
                }
            }

            return true;
        }

        public bool IsUniqueCharactersOnlyBoolean(string phrase)
        {
            bool[] boolAbc = new bool[256];

            foreach (var c in phrase)
            {
                int ascii = (int)c;

                if (boolAbc[ascii])
                {
                    return false;
                }

                boolAbc[ascii] = true;
                                
            }
            
            return true;
        }
    }
}
