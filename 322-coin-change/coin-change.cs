public class Solution {
    public int CoinChange(int[] coins, int amount) {
        var dp = new int[amount + 1];
        for(int i = 1; i < dp.Length; i++){
            dp[i] = amount + 1;
        }
        dp[0] = 0;
        for(int j = 1; j < dp.Length; j++){
            foreach(int c in coins){
                if(j - c >= 0){
                    dp[j] = Min(dp[j], 1 + dp[j - c]);
                }
            }
        }

        return (dp[amount] == amount + 1) ? -1 : dp[amount];
    }

    private int Min(int a, int b){
        return (a < b) ? a : b;
    }
}