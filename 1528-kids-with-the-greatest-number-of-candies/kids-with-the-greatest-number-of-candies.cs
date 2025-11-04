public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int greatestNumber = 0;
        var result = new List<bool>();
        for(int i = 0; i < candies.Length; i++){
            if(candies[i] > greatestNumber){
                greatestNumber = candies[i];
            }
        }

        for(int j = 0; j < candies.Length; j++){
            result.Add(candies[j] >= greatestNumber - extraCandies);
        }

        return result;
    }
}