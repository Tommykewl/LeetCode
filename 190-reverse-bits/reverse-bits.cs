public class Solution {
    public uint reverseBits(uint n) {
        uint reversed = 0;
        uint reversedBase = 2147483648;
        while(n > 0){
            if(n % 2 == 1){
                reversed += reversedBase;
            }

            n = n >> 1;
            reversedBase = reversedBase >> 1;
        }

        return reversed;
    }
}