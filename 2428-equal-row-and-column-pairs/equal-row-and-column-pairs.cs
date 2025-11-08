public class Solution {
    public int EqualPairs(int[][] grid) {
        int numberOfEqualRowCol = 0;
        Dictionary<string, int> rowDict = new Dictionary<string, int>();
        
        for(int i = 0; i < grid.Length; i++){
            var str1 = "";
            for(int m = 0; m < grid.Length; m++){
                str1 += grid[i][m] + ",";
            }
            if(rowDict.ContainsKey(str1)){
                rowDict[str1]++;
            }else{
                rowDict[str1] = 1;
            }
        }

        for(int j = 0; j < grid.Length; j++){
            var str2 = "";
            for(int z = 0; z < grid.Length; z++){
                str2 += grid[z][j] + ",";
            }

            if(rowDict.ContainsKey(str2)){
                numberOfEqualRowCol += rowDict[str2];
            }
        }

        return numberOfEqualRowCol;
    }
}