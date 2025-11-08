public class Solution {
    public string RemoveStars(string s) {
        Stack<char> wordStack = new Stack<char>();

        foreach(var c in s){
            if(c == '*'){
                wordStack.Pop();
            }else{
                wordStack.Push(c);
            }
        }

        var outputString = string.Empty;
        while(wordStack.Count() != 0){
            outputString = wordStack.Pop() + outputString;
        }

        return outputString;
    }
}