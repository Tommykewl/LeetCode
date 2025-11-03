public class Solution {
    public int MaxVowels(string s, int k) {
        int numberOfVowelsInWindow = 0;
        int highestnumberOfVowels = 0;
        int i = 0;
        int j = 0;
        while(j < k){
            if(this.isVowel(s[j])){
                numberOfVowelsInWindow++;
                highestnumberOfVowels++;
            }
            j++;
        }
        
        while(j < s.Length){
            numberOfVowelsInWindow = numberOfVowelsInWindow + (this.isVowel(s[j]) ? 1 : 0) - (this.isVowel(s[i]) ? 1 : 0);
            if(numberOfVowelsInWindow > highestnumberOfVowels){
                highestnumberOfVowels = numberOfVowelsInWindow;
            }
            i++;
            j++;
        }

        return highestnumberOfVowels;
    }

    private bool isVowel(char c){
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
}