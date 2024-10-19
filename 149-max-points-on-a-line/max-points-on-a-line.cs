public class Solution {
    public int MaxPoints(int[][] points) {
        if(points.Length < 3) return points.Length;
        var maxNumberOfPoints = 0;
        for(int i = 0; i < points.Length - 1; i++){
            Dictionary<(int, int), int> cache = new Dictionary<(int, int), int>();
            int localMax = 0;
            for(int j = i + 1; j < points.Length; j++){
                // get the dx and dy
                int dx = points[j][0] - points[i][0];
                int dy = points[j][1] - points[i][1];

                int gcd = this.GCD(dx, dy);
                dx /= gcd;
                dy /= gcd;

                if(dx < 0){
                    dx = -dx;
                    dy = -dy;
                }

                if(!cache.ContainsKey((dx, dy))){
                    cache[(dx,dy)] = 0;
                }

                cache[(dx, dy)]++;
                localMax = this.Max(localMax, cache[(dx, dy)]);
            }

            maxNumberOfPoints = this.Max(maxNumberOfPoints, localMax + 1);
        }

        return maxNumberOfPoints;
    }

    private int GCD(int a, int b){
        if(b == 0) return a;
        return GCD(b, a % b);
    }

    private int Max(int a, int b){
        return (a > b) ? a : b;
    }
}