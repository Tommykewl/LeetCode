public class Solution {
    public int HammingWeight(int n) {
        int weight = 0;
        while(n > 0){
            weight += n % 2;
            n >>= 1;
        }

        return weight;
    }
}