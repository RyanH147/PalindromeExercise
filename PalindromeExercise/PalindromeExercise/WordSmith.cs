using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            //reverse the word  //racecar ---> 7 ---> 6
            var reversed = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i]; //reversed = reversed + word[i]
            }

            //compare the original with the reversed
            if(reversed.ToLower() == word.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }

            //return whether they are the same or not
        }
    }
}
