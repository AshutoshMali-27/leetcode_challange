//Given a pattern and a string s, find if s follows the same pattern.

//Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s.


//Example 1:

//Input: pattern = "abba", s = "dog cat cat dog"
//Output: true
using System.Collections.Generic;
using System;

class Solution
{
    public static boolean wordPattern(String pattern, String s)
    {
        String[] words = s.split(" ");

        if (pattern.length() != words.length)
        {
            return false;
        }

        Map<Character, String> charToWord = new HashMap<>();
        Set<String> usedWords = new HashSet<>();

        for (int i = 0; i < pattern.length(); i++)
        {
            char currentChar = pattern.charAt(i);
            String currentWord = words[i];

            if (charToWord.containsKey(currentChar))
            {
                if (!charToWord.get(currentChar).equals(currentWord))
                {
                    return false;
                }
            }
            else
            {
                if (usedWords.contains(currentWord))
                {
                    return false;
                }

                charToWord.put(currentChar, currentWord);
                usedWords.add(currentWord);
            }
        }

        return true;
    }
}
