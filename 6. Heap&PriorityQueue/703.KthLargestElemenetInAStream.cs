public class KthLargest {
    

    private PriorityQueue<int,int> numbers;
    private int k;
    public KthLargest(int k, int[] nums) {
        this.numbers = new();
        this.k = k;
        for(int i =0; i<nums.Length; i++)
        {
            numbers.Enqueue(nums[i],nums[i]);
            if(this.numbers.Count>this.k)
                numbers.Dequeue();
        }
    }
    
    public int Add(int val) {
        this.numbers.Enqueue(val,val);
        if(this.numbers.Count>this.k)
                this.numbers.Dequeue();
        return this.numbers.Peek();
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */