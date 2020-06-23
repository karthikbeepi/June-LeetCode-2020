using System;

class CoinChange {

    int[,] dp;
    public int Change(int amount, int[] coins) {

        dp = new int[amount+1 , coins.Length+1];

        for(int i=0; i<amount+1; i++){
            for(int j=0; j<coins.Length+1; j++) {
                if( i == 0 || j == 0) {
                    dp[i, j] = 0;
                } else {
                    if(i-coins[j-1]==0) {
                        dp[i, j] = 1+ dp[i, j-1];
                    } else if(i-coins[j-1]>0 && dp[i-coins[j-1], j]>0) {
                        dp[i, j] = 1+ dp[i-coins[j-1], j-1];
                    } else {
                        dp[i, j] = dp[i, j-1];
                    }
                }
            }
        }

        return dp[amount, coins.Length];

    }
}