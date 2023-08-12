// namespace LeetCode;
//
// public class Solution
// {
//     public IList<int> GetRow(int rowIndex)
//     {
//         var row = new List<int>();
//
//         if (rowIndex < 0)
//         {
//             return row;
//         }
//         
//         row.Add(1);
//
//         for (var i = 1; i <= rowIndex; i++)
//         {
//             var newRow = new List<int>(i + 1);
//
//             newRow.Add(1);
//
//             for (var j = 1; j < i; j++)
//             {
//                 newRow.Add(row[j - 1] + row[j]);
//             }
//             newRow.Add(1);
//             row = newRow;
//         }
//         return row;
//     }
// }