// namespace LeetCode.RomanNumerals;
//
// public class Solution
// {
//     public int RomanToInt(string s)
//     {
//         var sum = 0;
//
//         // var romanNumbers = new Dictionary<int, int>()
//         // {
//         //     { 'I', 1 },
//         //     { 'V', 5 },
//         //     { 'X', 10 },
//         //     { 'L', 50 },
//         //     { 'C', 100 },
//         //     { 'D', 500 },
//         //     { 'M', 1000 }
//         // };
//         
//         int previousValue = 0;
//
//         for (int i = s.Length - 1; i >= 0; i--)
//         {
//             int currentValue;
//             switch (s[i])
//             {
//                 case 'I': currentValue = 1; break;
//                 case 'V': currentValue = 5; break;
//                 case 'X': currentValue = 10; break;
//                 case 'L': currentValue = 50; break;
//                 case 'C': currentValue = 100; break;
//                 case 'D': currentValue = 500; break;
//                 case 'M': currentValue = 1000; break;
//                 default: throw new ArgumentException("Invalid Roman numeral character.");
//             }
//     
//             if (currentValue < previousValue)
//             {
//                 sum -= currentValue;
//             }
//             else
//             {
//                 sum += currentValue;
//             }
//     
//             previousValue = currentValue;
//         }
//
//         return sum;
//     }
// }