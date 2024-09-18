public class Solution {
    public int[] FindRedundantConnection(int[][] edges) {
        int[] parents = new int[edges.Length];
        int[] rank = new int[edges.Length];
        List<int[]> canBeRemovedEdges = new List<int[]>();

        for(int i = 0; i < edges.Length; i++){
            rank[i] = 1;
            parents[i] = i;
        }

        foreach(var edge in edges){
            var x = edge[0] - 1;
            var y = edge[1] - 1;

            if(!Union(parents, rank, x, y)){
                canBeRemovedEdges.Add(edge);
            }
        }

        return canBeRemovedEdges.Last();
    }

    private int Find(int[] parents, int node){
        if(node != parents[node]){
            parents[node] = Find(parents, parents[node]);
        }

        return parents[node];
    }

    private bool Union(int[] parents, int[] rank, int x, int y){
        var parentX = Find(parents, x);
        var parentY = Find(parents, y);

        if(parentX == parentY){
            return false;
        }

        if(rank[parentX] > rank[parentY]){
            parents[parentY] = parentX;
        }else if(rank[parentY] > rank[parentX]){
            parents[parentX] = parentY;
        }else{
            parents[parentY] = parentX;
            rank[parentX]++;
        }
        return true;
    }
}