


//Given a string s consisting of words and spaces, return the length of the last word in the string.

//A word is a maximal 
//substring
// consisting of non-space characters only.



//Example 1:

//Input: s = "Hello World"
//Output: 5
//Explanation: The last word is "World" with length 5.






using System;

public class Solution
{
    public int LengthOfLastWord(string s)
    {
    
        string[] words = s.Split(' ');
        for (int i = words.Length - 1; i >= 0; i--)
        {
            if (!string.IsNullOrWhiteSpace(words[i]))
            {
                return words[i].Length;
            }
        }
        return 0;
    }

}


string input = "Hello World";
int length = LengthOfLastWord(input);
Console.WriteLine("Length of the last word: " + length); // Output: 5