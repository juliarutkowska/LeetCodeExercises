
//Enqueue: This operation adds an element to the end of the queue.
//In other words, it inserts an item into the queue. In the context of the provided code,
//Enqueue is used to add elements (arrays representing coordinates) to the end of the queue q.
//
// Dequeue: This operation removes and returns the element at the front of the queue.
// It retrieves and removes the first item in the queue. In the context of the provided code,
// Dequeue is used to remove elements (arrays representing coordinates) from the front of the queue q.

namespace LeetCode;

public class Solution
{
    public void WallsAndGates(int[][]? rooms)
    {
        if (rooms == null || rooms.Length == 0 || rooms[0].Length == 0) return;
        
        //rows
        var m = rooms.Length;
        //columns
        var n = rooms[0].Length;
        var q = new Queue<int[]>();
        //up, down, right, left
        int[] dirs = { -1, 0, 1, 0, -1 };
            // Add all gates to the queue
            for (var i = 0; i < m; ++i) 
            {
                for (var j = 0; j < n; ++j) 
                { 
                    if (rooms[i][j] == 0) 
                    {
                        q.Enqueue(new[] {i, j});
                    }
                }
            }
            
            
            // BFS
            while (q.Count > 0) {
                var p = q.Dequeue();
                //assigns the value of the first element of the p array (the row index) to the variable x0
                var x0 = p[0];
                //assigns the value of the second element of the p array (the column index) to the variable y0
                var y0 = p[1];
                for (var k = 0; k < 4; ++k) {
                    var x = x0 + dirs[k];
                    var y = y0 + dirs[k + 1];
                    if (x >= 0 && x < m && y >= 0 && y < n && rooms[x][y] == int.MaxValue) {
                        rooms[x][y] = rooms[x0][y0] + 1;
                        q.Enqueue(new [] {x, y});
                    }
                }
            }
    }
}
 
