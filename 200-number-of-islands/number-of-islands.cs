public class Solution {
    private HashSet<(int, int)> used = new HashSet<(int, int)>();

    public int NumIslands(char[][] grid) {
        int numberOfIslands = 0;
        for(int i = 0; i < grid.Length; i++){
            for(int j = 0; j < grid[i].Length; j++){
                if(grid[i][j] == '1' && !this.used.Contains((i, j))){
                    numberOfIslands++;
                    this.BFS(grid, i, j);
                }
            }
        }

        return numberOfIslands;
    }

    private void BFS(char[][] grid, int i, int j){
        Queue<(int, int)> bfsCache = new Queue<(int, int)>();
        bfsCache.Enqueue((i, j));
        this.used.Add((i, j));

        while(bfsCache.Count > 0){
            var coOrdinate = bfsCache.Dequeue();
            // left
            if(coOrdinate.Item2 > 0 && !this.used.Contains((coOrdinate.Item1, coOrdinate.Item2 - 1)) && grid[coOrdinate.Item1][coOrdinate.Item2 - 1] == '1'){
                bfsCache.Enqueue((coOrdinate.Item1, coOrdinate.Item2 - 1));
                this.used.Add((coOrdinate.Item1, coOrdinate.Item2 - 1));
            }

            // top
            if(coOrdinate.Item1 > 0 && !this.used.Contains((coOrdinate.Item1 - 1, coOrdinate.Item2)) && grid[coOrdinate.Item1 - 1][coOrdinate.Item2] == '1'){
                bfsCache.Enqueue((coOrdinate.Item1 - 1, coOrdinate.Item2));
                this.used.Add((coOrdinate.Item1 - 1, coOrdinate.Item2));
            }

            // right
            if(coOrdinate.Item2 < grid[0].Length - 1 && !this.used.Contains((coOrdinate.Item1, coOrdinate.Item2 + 1)) && grid[coOrdinate.Item1][coOrdinate.Item2 + 1] == '1'){
                bfsCache.Enqueue((coOrdinate.Item1, coOrdinate.Item2 + 1));
                this.used.Add((coOrdinate.Item1, coOrdinate.Item2 + 1));
            }

            // bottom
            if(coOrdinate.Item1 < grid.Length - 1 && !this.used.Contains((coOrdinate.Item1 + 1, coOrdinate.Item2)) && grid[coOrdinate.Item1 + 1][coOrdinate.Item2] == '1'){
                bfsCache.Enqueue((coOrdinate.Item1 + 1, coOrdinate.Item2));
                this.used.Add((coOrdinate.Item1 + 1, coOrdinate.Item2));
            }
        }
    }
}