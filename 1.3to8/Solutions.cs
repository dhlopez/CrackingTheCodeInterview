using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodeInterviewChapter1._1._3to8
{
    public class Solutions
    {
        //1.3
        public string RemoveDuplicate(string word)
        {
            foreach (char searchLetter in word)
            {
                int hits = 0;
                int counter = 0;

                foreach (char comparisonLetter in word)
                {
                    if (searchLetter.Equals(comparisonLetter))
                    {
                        hits++;
                    }
                    if (hits > 1)
                    {
                        word = word.Remove(counter, 1);
                        hits = 0;
                        counter--;
                    }

                    counter++;
                }
            }

            return word;
        }
    
        //1.4
        public bool IsAnagram(string word1, string word2)
        {
            bool isAnagram = false;

            if (string.IsNullOrEmpty(word1) || string.IsNullOrEmpty(word2))
                return false;

            if (word1.Length != word2.Length)
                return false;

            int reverseIndex = word2.Length - 1;

            for (int i = 0; i < word1.Length; i++)
            {
                Console.WriteLine("Comparing {0} and {1}", word1[i], word2[reverseIndex]);
                if (!word1[i].Equals(word2[reverseIndex]))
                {
                    return isAnagram;
                }
                reverseIndex--;
            }          

            return true;    
        }

        public bool IsAnagram2(string word1, string word2)
        {
            char[] charWord1 = word1.ToCharArray();
            char[] charWord2 = word2.ToCharArray();

            Array.Sort(charWord1);
            Array.Sort(charWord2);

            if (string.IsNullOrEmpty(word1) || string.IsNullOrEmpty(word2))
                return false;

            if (word1.Length != word2.Length)
                return false;

            for(int i=0; i<charWord1.Length; i++)
            {
                if (!charWord1[i].Equals(charWord2[i]))
                {
                    return false;
                }
            }

            return true;
        }

        //1.5 - Write a method to replace all spaces in a string with ‘%20’.
        public string ReplaceSpaces(string stringWithSpaces)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char character in stringWithSpaces)
            {
                if (character.Equals(' '))
                {
                    sb.Append("%20");
                }
                else 
                {
                    sb.Append(character);
                }
            }

            string result = sb.ToString();

            return result;
        }

        //1.6 - NxN matrix, rotate the image by 90 degrees
        public string[,] RotateMatrix90Degrees(int matrixSize)
        {
            //TODO:only for square matrix validation
            string[,] originalMatrix = new string[matrixSize,matrixSize];
            string[,] resultMatrix = new string[matrixSize, matrixSize];
            int matrixIndex = matrixSize - 1;
            int value = 1;

            /*
             * [1][2][3]  [1]: moves from [0,0] -> [0,2] / [3]: moves from [0,2] -> [2,2]
             * [4][5][6]
             * [7][8][9]
             * .
             * .
             * .
             * [7][4][1]
             * [8][5][2]
             * [9][6][3]
             * 
             * first row becomes third column
             * second row -> second column
             * third row -> first column
             * 
             */

            //fill
            for (int i = 0; i <= matrixIndex; i++)
            {
                for (int j = 0; j <= matrixIndex; j++)
                {
                    originalMatrix[i, j] = value.ToString(); ;
                    value++;
                }
            }

            //arrange
            for (int i = 0; i <= matrixIndex; i++)
            {
                for (int j = 0; j <= matrixIndex; j++)
                {
                    resultMatrix[j, matrixIndex - i] = originalMatrix[i, j];
                }
            }

            //print
            for (int i = 0; i <= matrixIndex; i++)
            {
                for (int j = 0; j <= matrixIndex; j++)
                {
                    Console.WriteLine(resultMatrix[i,j]);
                }
            }

            return resultMatrix;
        }

        //1.7 - Write an algorithm such that if an element in an MxN matrix is 0, its entire row and column is set to 0.
        public string[,] FindZeroInMatrixAndClearValues(string[,] originalMatrix)
        {
            string[,] resultMatrix = (string[,])originalMatrix.Clone();
            int zeroColumn = -1;
            int zeroRow = -1;

            
            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++) 
                {
                    if (resultMatrix[i, j].Equals("0"))
                    {
                        zeroRow = i;
                        zeroColumn = j;
                        i = resultMatrix.GetLength(0);
                        break;
                    }
                }
            }
            /*
            [1][3][4]
            [5][7][0] ->1,2
            [5][6][7]
            */

            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    if (zeroRow == i || zeroColumn == j)
                    {
                        resultMatrix[i, j] = "0";
                    }
                }
            }

            //find if any value is zero
            //find the row and column from the zero value
            //use those values to clear row and columns

            return resultMatrix;

        }
    }
}
