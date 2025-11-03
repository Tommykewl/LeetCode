public class Solution {
    public string ReverseWords(string s) {
        var arr = s.Trim().Split(" ").Where(j => j != string.Empty).ToArray();
        for(int i = 0; i < arr.Length / 2; i++){
            var k = arr[i];
            arr[i] = arr[arr.Length - i - 1];
            arr[arr.Length - i - 1] = k;
        }

        return String.Join(' ', arr);
    }
}