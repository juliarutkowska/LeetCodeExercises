using LeetCode;

namespace TestWallsAndGates;
using Xunit;

public class SolutionTests
{ 
        [Fact]
        public void WallsAndGates_Test1() {
            var solution = new Solution();
        
            var rooms = new int[][] {
                [int.MaxValue, -1, 0, int.MaxValue],
                [int.MaxValue, int.MaxValue, int.MaxValue, -1],
                [int.MaxValue, -1, int.MaxValue, -1],
                [0, -1, int.MaxValue, int.MaxValue]
            };
        
            solution.WallsAndGates(rooms);
        
            var expected = new int[][] {
                [3, -1, 0, 1],
                [2, 2, 1, -1],
                [1, -1, 2, -1],
                [0, -1, 3, 4]
            };
        
            Assert.Equal(expected, rooms);
        }
    
        [Fact]
        public void WallsAndGates_Test2() {
            var solution = new Solution();
        
            var rooms = new[] { new[] { -1 } };
        
            solution.WallsAndGates(rooms);
        
            var expected = new[] { new[] { -1 } };
        
            Assert.Equal(expected, rooms);
        }
}