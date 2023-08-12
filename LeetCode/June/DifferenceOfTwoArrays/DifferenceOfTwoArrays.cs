// namespace LeetCode;
//
// public class DifferenceOfTwoArrays 
// {
//     public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) 
//     {
//         HashSet<int> set1 = new HashSet<int>(nums1);
//             HashSet<int> set2 = new HashSet<int>(nums2);
//             HashSet<int> diff1 = new HashSet<int>(set1);
//             HashSet<int> diff2 = new HashSet<int>(set2);
//             diff1.ExceptWith(set2);
//             diff2.ExceptWith(set1);
//             return new int[][] { diff1.ToArray(), diff2.ToArray() };
//
//     }
// }