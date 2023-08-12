// namespace LeetCode;
//
// public class PalindromeNumbers
// {
//     public bool IsPalindrome(int x)
//         {
//             // negative numbers can't be palindrome
//             if (x < 0)
//                 return false;
//
//             // hold the x in temp to play with it without changing the original value of x
//             int temp = x;
//         
//             int lastDigit;
//             int reverse = 0;
//             int factor = 10;
//         
//             while (temp > 0)
//             {
//                 // get the last digit
//                 lastDigit = temp % factor;
//
//                 // move through the tens, hundreds column
//                 reverse = (reverse * factor) + lastDigit;
//
//                 // remove last digit
//                 temp /= 10;
//             }
//
//             return x == reverse;
//         }
// }