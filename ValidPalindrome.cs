﻿
//A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

//Given a string s, return true if it is a palindrome, or false otherwise.


using System;
using System.Text.RegularExpressions;

public class Solution
{
    public bool IsPalindrome(string s)
    {


        string cleanedString = Regex.Replace(s.ToLower(), "[^a-z0-9]", "");

        int left = 0;
        int right = cleanedString.Length - 1;

        while (left < right)
        {
            if (cleanedString[left] != cleanedString[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}