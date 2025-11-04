public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        var result = new List<IList<int>>();
        List<int> first = new List<int>();
        List<int> second = new List<int>();

        foreach (int i in nums1){
            if(!dict.ContainsKey(i)){
                dict.Add(i, 1);
            }
        }

        foreach(int j in nums2){
            if(dict.ContainsKey(j)){
                if(dict[j] == 1){
                    dict[j] = 0;
                }
            }else{
                dict.Add(j, 2);
            }
        }

        foreach (KeyValuePair<int, int> entry in dict)
        {
            if(entry.Value == 1){
                first.Add(entry.Key);
            }else if(entry.Value == 2){
                second.Add(entry.Key);
            }
        }

        result.Add(first);
        result.Add(second);

        return result;
    }
}