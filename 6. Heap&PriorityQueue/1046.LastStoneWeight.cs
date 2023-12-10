public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int,int> pq =new();
        foreach(var stone in stones)
            pq.Enqueue(stone,(0-stone));
        while(!(pq.Count==1))
        {
            int y = pq.Dequeue();
            int x = pq.Dequeue();
            pq.Enqueue((y-x),(x-y));
        }
        return pq.Peek();
        
    }
}