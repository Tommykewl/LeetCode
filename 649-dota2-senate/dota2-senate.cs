public class Solution {
    public string PredictPartyVictory(string senate) {
        List<char> q = new List<char>();
        foreach (var c in senate){
            q.Add(c);
        }

        while(true){
            var member = q.First();
            q.RemoveAt(0);
            bool victoryDeclared = true;
            for(int i = 0; i < q.Count(); i++){
                if(q[i] != member){
                    victoryDeclared = false;
                    q.RemoveAt(i);
                    break;
                }
            }

            if(victoryDeclared){
                return (member == 'R') ? "Radiant" : "Dire";
            }else{
                q.Add(member);
            }
        }
    }
}