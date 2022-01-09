/* 
 
YOU ARE NOT ALLOWED TO MODIFY ANY FUNCTION DEFINATION's PROVIDED.
WRITE YOUR CODE IN THE RESPECTIVE FUNCTION BLOCK

*/
using System;

namespace DIS_Assignmnet1_SPRING_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}",final_string);
            Console.WriteLine();

            //Question 2:
            string[] word1 = new string[]{"ab","c"};
            string[] word2 =new string[]{"a","bc"};
            bool flag = ArrayStringsAreEqual(word1,word2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] nums = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(nums);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(matrix);
            Console.WriteLine("The sum of diagonal elements are {0}:", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String word3 = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(word3, indices);
            Console.WriteLine("The Final string after rotation is ", rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string word4 ="abcdefd";
            char ch ='d';
            string reversed_string = ReversePrefix(word4, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            Console.WriteLine();

        }

        /* 
        <summary>
        Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.

        Example 1:
        Input: s = "lightcodeisacommunityforcoders"
        Output: "lghtcdscmmntyfrcdrs"

        Example 2:
        Input: s = "aeiou"
        Output: ""

        Constraints:
        •	0 <= s.length <= 10000
        s consists of uppercase and lowercase letters
        </summary>
        */

        private static string RemoveVowels(string s)
        {
            try
            {
                // write your code here
                String final_string ="";
                return final_string;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /* 
        <summary>
       Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
       A string is represented by an array if the array elements concatenated in order forms the string.
       Example 1:
       Input: word1 = ["ab", "c"], word2 = ["a", "bc"]
       Output: true
       Explanation:
       word1 represents string "ab" + "c" -> "abc"
       word2 represents string "a" + "bc" -> "abc"
       The strings are the same, so return true.
       Example 2:
       Input: word1 = ["a", "cb"], word2 = ["ab", "c"]
       Output: false

       Example 3:
       Input: word1  = ["abc", "d", "defg"], word2 = ["abcddefg"]
       Output: true
       </summary>
       */

        private static bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            try
            {
                // write your code here.
                return false;
            }
            catch (Exception)
            {

                throw;
            }

        }
        /*
        <summary> 
       You are given an integer array nums. The unique elements of an array are the elements that appear exactly once in the array.
       Return the sum of all the unique elements of nums.
       Example 1:
       Input: nums = [1,2,3,2]
       Output: 4
       Explanation: The unique elements are [1,3], and the sum is 4.
       Example 2:
       Input: nums = [1,1,1,1,1]
       Output: 0
       Explanation: There are no unique elements, and the sum is 0.
       Example 3:
       Input: nums = [1,2,3,4,5]
       Output: 15
       Explanation: The unique elements are [1,2,3,4,5], and the sum is 15.
       </summary>
        */

        private static int SumOfUnique(int[] nums)
        {
            try
            {
                // write your code here
                return 0;

            }
            catch (Exception)
            {
                throw;
            }
        }
       /*
       
       <summary>
      Given a square matrix mat, return the sum of the matrix diagonals.
      Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.

      Example 1:
      Input: mat = [[1,2,3],[4,5,6], [7,8,9]]
      Output: 25
      Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
      Notice that element mat[1][1] = 5 is counted only once.
      Example 2:
      Input: mat = [[1,1,1,1], [1,1,1,1],[1,1,1,1], [1,1,1,1]]
      Output: 8
      Example 3:
      Input: mat = [[5]]
      Output: 5
      </summary>

       */

        private static int DiagonalSum(int[,] matrix)
        {
            try
            {
                // write your code here.

                return 0;
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }



        /*
         
        <summary>
        Given a string s and an integer array indices of the same length.
        The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        Return the shuffled string.

        Example 3:
        Input: s = "aiohn", indices = [3,1,4,2,0]
        Output: "nihao"

        */

        private static string RestoreString(string s, int[] indices)
        {
            try
            {
                // write your code here.
                return "null";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

      /*
       <summary>
      Given a 0-indexed string word and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
      For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
      Return the resulting string.

      Example 1:
      Input: word = "abcdefd", ch = "d"
      Output: "dcbaefd"
      Explanation: The first occurrence of "d" is at index 3. 
      Reverse the part of word from 0 to 3 (inclusive), the resulting string is "dcbaefd".

      Example 2:
      Input: word = "xyxzxe", ch = "z"
      Output: "zxyxxe"
      Explanation: The first and only occurrence of "z" is at index 3.
      Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".

      Example 3:
      Input: word = "abcd", ch = "z"
      Output: "abcd"
      Explanation: "z" does not exist in word.
      You should not do any reverse operation, the resulting string is "abcd".
      */

        private static string ReversePrefix(string word, char ch)
        {
            try
            {
                String prefix_string ="";
                return prefix_string;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
