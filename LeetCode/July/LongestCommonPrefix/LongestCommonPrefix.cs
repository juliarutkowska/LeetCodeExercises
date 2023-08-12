namespace LeetCode;

public class LongestCommonPrefix
{

    public string LongestPrefix(string[] strs)
    {
        if (strs.Length == 0)
        {
            return "";
        }

        var firstWord = strs[0];
        for (var i = 0; i < firstWord.Length; i++)
        {
            var currentLetter = firstWord[i];
            for (var j = 1; j < strs.Length; j++)
            {
                
            }
        }

        return firstWord;
    }
}
