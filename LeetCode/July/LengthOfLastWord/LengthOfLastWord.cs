namespace LeetCode;

    public class LengthOfLastWord 
    {
        public int LengthOfLastWords(string s)
        {
            s = s.Trim();
    
            if (string.IsNullOrEmpty(s))
                return 0;
    
            var word = s.Split(' ');
    
            var lastWord = word[word.Length - 1];
    
            return lastWord.Length;
        }
    }