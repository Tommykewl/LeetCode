public class Solution {
    private Dictionary<int, int> cache = new Dictionary<int, int>();
    public int ClimbStairs(int n) {
        if(n < 2) return 1;
        var oneWay = 0;
        var twoWay = 0;
        if(cache.TryGetValue(n - 1, out oneWay)){
        }else{
            oneWay = ClimbStairs(n-1);
            cache[n-1] = oneWay;
        }
        if(cache.TryGetValue(n - 2, out twoWay)){
        }else{
            twoWay = ClimbStairs(n-2);
            cache[n-2] = twoWay;
        }
        return oneWay + twoWay;
    }
}