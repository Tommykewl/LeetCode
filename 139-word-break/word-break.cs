public class TrieNode{
    public TrieNode[] next { get; } = new TrieNode[26];
    public bool isEndNode { get; set; } = false;
}

public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        var trie = new TrieNode();

        // construct the Trie
        foreach(var word in wordDict){
            var chrarr = word.ToCharArray();
            var currNode = trie;
            foreach(char chr in chrarr){
                currNode = FillTrie(chr, currNode);
            }
            currNode.isEndNode = true;
        }

        // search in Trie
        var ch = s.ToCharArray();
        var dp = new bool[ch.Length + 1];
        dp[0] = true;
        var ind = 0;
        for(int i = 0; i < ch.Length; i++){
            if(dp[i]){
                var curr = trie;
                for(int j = i; j < ch.Length; j++){
                    var charindex = (int)ch[j] - (int)'a';
                    var nextNode = curr.next[charindex];
                    if(nextNode == null){
                        break;
                    }
                    curr = nextNode;
                    if(curr.isEndNode){
                        dp[j + 1] = true;
                    }
                }
            }
        }

        return dp[ch.Length];
    }

    private TrieNode FillTrie(char c, TrieNode currNode){
        var index = (int)c - (int)'a';
        if(currNode.next[index] == null){
            var node = new TrieNode();
            currNode.next[index] = node;
        }
        return currNode.next[index];
    }
}