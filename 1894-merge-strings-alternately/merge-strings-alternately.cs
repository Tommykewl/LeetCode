public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int i = 0;
        int j = 0;
        string appendedStr = "";
        while(i < word1.Length && j < word2.Length){
            if(i > j){
                appendedStr+=word2[j];
                j++;
            }else{
                appendedStr+=word1[i];
                i++;
            }
        }

        while(i < word1.Length){
            appendedStr+=word1[i];
            i++;
        }

        while(j < word2.Length){
            appendedStr+=word2[j];
            j++;
        }

        return appendedStr;
    }
}