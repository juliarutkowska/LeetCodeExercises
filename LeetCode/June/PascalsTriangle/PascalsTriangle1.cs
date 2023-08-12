// namespace LeetCode;
//
// public class Solution
// {
//     public IList<IList<int>> Generate(int numRows)
//     {
         // var result = new List<IList<int>>();
         //
         // var prev = new List<int>{1,1};
         //
         // for (var i = 1; i <= numRows; i++)
         // {
         //     var row = new List<int>();
         //
         //     for (var j = 0; j < i; j++)
         //     {
         //         if (j == 0 || j == i - 1)
         //         {
         //             row.Add(1);
         //         }
         //         else
         //         {
         //             row.Add(prev[j-1]+prev[j]);
         //         }
         //     }
         //     
         //     result.Add(row);
         //     prev = row;
         // }
         //
         // return result;
//     }
// }