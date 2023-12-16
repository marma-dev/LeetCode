public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        return Solution2(nums);
    }
    // public int[] Solution1(int[] nums) {
    //     /*
    //         take a new array with 1 <identity element> as all element
    //         For one element, have 2  pointers, one moving left and multiplying product, and one doing same on right
    //         then multiply both and place in same index
    //         TC: (O(n2)) SC: O(n)
    //     */
    // }
    public int[] Solution2(int[] nums) {
        /*
            Take 2 int with initialized with ID element 1;
            start from 

            1 2 3 4
           
            1*3
            t = 1
            r 1*1
            l 3*1
        */

        int[] ans = new int[nums.Length];
        for(int i=0;i<nums.Length; i++)
        {
            ans[i] = 1;
        }
        int left =1, right=1;
        for(int i=1, j= nums.Length - 2; i<nums.Length; i++,j-- )
        {
            left *= nums[i-1];
            right *= nums[j+1];

            ans[i] *= left;
            ans[j] *= right;
        }
        return ans;

        

    }
}