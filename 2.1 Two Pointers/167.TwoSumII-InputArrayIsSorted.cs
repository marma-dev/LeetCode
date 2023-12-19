public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        //have two indecies/pointers one at start and one at end, then move left is sum is sum is less than target, and right if more.

        for(int i =0, j =numbers.Length-1; i<numbers.Length && j>=0 && i<j;)
        {
            int sum = numbers[i] + numbers[j];
            if(sum==target)
                return new int[]{i+1,j+1};
            if(sum>target)
            {
                j--;
            }
            else
            {
                i++;
            }   
        
        }
        //not found case
        return new int[0];
    }
}