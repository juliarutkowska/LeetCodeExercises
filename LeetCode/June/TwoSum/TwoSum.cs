// namespace LeetCode;
//
// public class Solution
// {
//     // public int[] TwoSum(int[] nums, int target)
//     // {
//     //     for (var i = 0; i < nums.Length; i++)
//     //     {
//     //         for (var j = i + 1; j < nums.Length; j++)
//     //         {
//     //             if (nums[i] + nums[j] == target)
//     //             {
//     //                 return new int[] { i, j };
//     //             }
//     //         }
//     //     }
//     //     return Array.Empty<int>();
//     // }
//
//     public int[] TwoSum(int[] nums, int target)
//     {
//         // Create a dictionary to store the indices of each number
//         var dict = new Dictionary<int, int>();
//     
//         // Iterate through the array
//         for (var i = 0; i < nums.Length; i++)
//         {
//             var complement = target - nums[i];
//     
//             // Check if the complement is already in the dictionary
//             if (dict.TryGetValue(complement, out var complementIndex))
//             {
//                 // If it is, then we've found the pair of numbers that add up to the target
//                 return new int[] { complementIndex, i };
//             }
//     
//             // Otherwise, add the current number and its index to the dictionary
//             dict[nums[i]] = i;
//         }
//         
//         return Array.Empty<int>();
//     }
//
// }
//
//
