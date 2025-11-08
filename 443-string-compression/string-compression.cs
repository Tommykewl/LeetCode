public class Solution {
    public int Compress(char[] chars) {
        if(chars.Length == 1) return 1;

        var i = 0;
        var j = 0;
        while(j < chars.Length){
            if((j < chars.Length - 1) && (chars[j] == chars[j + 1])){
                // calculate the repeating characters length
                var n = 1;
                while((j < chars.Length - 1) && (chars[j] == chars[j + 1])){
                    n++;
                    j++;
                }

                chars[i] = chars[j];
                i++;
                j++;

                var strN = n.ToString();

                foreach(char c in strN){
                    chars[i] = c;
                    i++;
                }

            }else{
                chars[i] = chars[j];
                i++;
                j++;
            }
        }

        return i;
    }
}