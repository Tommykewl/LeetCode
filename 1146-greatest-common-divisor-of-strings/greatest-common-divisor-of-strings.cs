public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        if(str1 + str2 != str2 + str1){
            return "";
        }

        int gcdLength = this.getGCD(str1.Length, str2.Length);

        return str1.Substring(0, gcdLength);
    }

    private int getGCD(int a, int b){
        while(b != 0){
            int r = a % b;
            a = b;
            b = r;
        }

        return a;
    }
}