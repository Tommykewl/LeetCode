public class Solution {
    private List<IList<int>> output = new List<IList<int>>();
    public IList<IList<int>> Combine(int n, int k) {
        CombineInternal(n, k, 1, new List<int>());
        return output;
    }

    private void CombineInternal(int n, int k, int start, List<int> combination){
        if(combination.Count == k){
            output.Add(new List<int>(combination));
            return;
        }

        for(int i = start; i < n + 1; i++){
            combination.Add(i);
            CombineInternal(n, k, i + 1, combination);
            combination.RemoveAt(combination.Count - 1);
        }
    }
}