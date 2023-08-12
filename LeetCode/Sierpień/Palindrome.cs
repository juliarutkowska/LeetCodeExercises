using System.Text.RegularExpressions;

namespace LeetCode;

public class Palindrome
{
    public bool IsPalindrome(string s)
    {
        var pattern = @"[^0-9a-zA-Z]+";
        s = System.Text.RegularExpressions.Regex.Replace(s, pattern, "").ToLower();
        var left = 0;
        var right = s.Length - 1;

        while (left <= right)
        {
            if (s[left] == s[right])
            {
                left++;
                right--;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}