public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[],int> pk  =new();
        foreach(var val in points)
        {
            pk.Enqueue(val,0-((int)Math.Pow(val[0],2) + (int)Math.Pow(val[1],2)));
            if(pk.Count>k)
                pk.Dequeue();
        }
        int[][] ans = new int[k][];
        int i = 0;
        while(pk.Count>0)
        {
            ans[i++] = pk.Dequeue();
        }
        return ans;
    }
}