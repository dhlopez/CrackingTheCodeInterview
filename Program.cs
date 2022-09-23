using CrackingTheCodeInterviewChapter1._1._1;
using CrackingTheCodeInterviewChapter1._1._2;
using CrackingTheCodeInterviewChapter1._1._3to8;
using System;

namespace CrackingTheCodeInterviewChapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            Solutions solutions = new Solutions();
            //1.1
            //FindIfUniqueCharacters uc = new FindIfUniqueCharacters();
            //Console.WriteLine(uc.IsUniqueCharactersOnly("pizza"));
            //Console.WriteLine(uc.IsUniqueCharactersOnlyNoDataStructure("piza"));
            //Console.WriteLine(uc.IsUniqueCharactersOnlyBoolean("pizza"));

            //1.2
            //CStyleString cs = new CStyleString();
            //Console.WriteLine(cs.ReverseString("pizza"));

            //1.3
            //Solutions solutions = new Solutions();
            //solutions.RemoveDuplicate("pizza");
            //Console.WriteLine(solutions.RemoveDuplicate("pizzazz"));

            //1.4 -> Anagram != palindromo
            //Solutions solutions = new Solutions();
            //if (solutions.IsAnagram2("pizeza", "aezzip"))
            //{
            //    Console.WriteLine("It is an anagram");
            //}
            //else 
            //{
            //    Console.WriteLine("Not an anagram");
            //}

            //1.5 - Write a method to replace all spaces in a string with ‘%20’.
            //Solutions solutions = new Solutions();
            //Console.WriteLine(solutions.ReplaceSpaces("test and test2"));

            //1.6 - NxN matrix, rotate the image by 90 degrees
            //solutions.RotateMatrix90Degrees(3);

            //1.7 - f an element in an MxN matrix is 0, its entire row and column is set to 0.
            string[,] originalMatrix = new string[3, 2] {
                { "1", "2" }, 
                { "4", "5" },
                { "0", "6" }
            };
            solutions.FindZeroInMatrixAndClearValues(originalMatrix);
        }
    }
}
