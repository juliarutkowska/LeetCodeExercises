namespace LeetCode;
public class SingleNumber 
{
    public int SingleNumbers(int[] nums)
    {
        var result = 0;

        foreach (var num in nums)
        {
            result ^= num;
        }

        return result;
    }
}


