public class Solution {
    public string PredictPartyVictory(string senate) {
        Queue<int> dirQueue = new Queue<int>();
        Queue<int> radQueue = new Queue<int>();
        int n = 0;
        foreach (var c in senate){
            if(c == 'D'){
                dirQueue.Enqueue(n);
            }else{
                radQueue.Enqueue(n);
            }
            n++;
        }

        while(dirQueue.Count() != 0 && radQueue.Count() != 0){
            var d = dirQueue.Dequeue();
            var r = radQueue.Dequeue();
            if(d > r){
                radQueue.Enqueue(n);
            }else{
                dirQueue.Enqueue(n);
            }
            n++;
        }

        return (dirQueue.Count() == 0) ? "Radiant" : "Dire";
    }
}