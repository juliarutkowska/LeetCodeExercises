namespace LeetCode;

public class ClimbingStairs 
{
    public int ClimbStairs(int n) 
    {
        switch (n)
        {
            case <= 0:
                return 0;
            case 1:
                return 1;
        }

        var waysToReach = new int[n + 1];
        waysToReach[0] = 1;
        waysToReach[1] = 1;

        for (var i = 2; i <= n; i++)
        {
            waysToReach[i] = waysToReach[i - 1] + waysToReach[i - 2];
        }

        return waysToReach[n];
    }
}