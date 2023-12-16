public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        /*
            CQ1: Can there be negative numbers?
                Yes
            CQ2: Can there be floats?
                No, only integers
            CQ3: What's the range of nums
                2 <= nums.length <= 104
                -109 <= nums[i] <= 109
                -109 <= target <= 109
            CQ4: Can there be more than 1 solution?
                No
            CQ5: Is it possible to have NO solution?
                It is guranteed to have exactly 1 solution
            CQ6: Does the order of indecies matter?
                No

            Solution1: 
                BRUTE FORCE
                For Every Element, run through the array to find a pair that matches to target
                TC: O(n2) ASC: O(1)
            
            Solution2:
                Sort the Array (say Increasing Order) using QuickSort or HeapSort
                Then have 2 indecies, I at start and J at end
                If sum of nums[i]+nums[j] > target 
                    then J--
                Else
                    I++
                    TILL J & I dont Cross (i.e. J!=I and J>I) 
                    TC: O(nlogn) ASC: O(logn) or O(1)
            
            Solution3:
                Using Dictionary <int,List<int>> for number with it's indecies

                TC: O(n) ASC O(n)
                
        */

        Dictionary<int,List<int>> UniqueDictionary = new();
        for(int i=0; i<nums.Length; i++)
        {
            int remainder = target - nums[i];
            if(UniqueDictionary.ContainsKey(remainder))
            {
                return new int[]{i, UniqueDictionary[remainder].First()};
            }
            else
            {
                if(!UniqueDictionary.ContainsKey(nums[i]))
                {
                    UniqueDictionary.Add(nums[i], new List<int>());
                    
                }
                UniqueDictionary[nums[i]].Add(i);
            }            
        }
        return new int[]{-1,-1};

    }
}