public class Solution {
    public bool ContainsDuplicate(int[] nums) {
         /*
            Clarifying Questions
            CQ1: Is Nums Sorted?
                -> No
                CQ1.1-> Can we Sort It?
                -> You can

            CQ2: Are numbers -ve too?
                -> Yes 

            CQ3: Can the array be empty?
                ->Yes
            
            CQ4: Can the input array be null?
                ->No

            CQ5: Can the array fit in memory?
                ->Yes

            Solution 1: Brute Force
            Two Indicies, i and J
                for each I, start J from i+1 to N, and look for same element,
                if found return true
            if none found in the array return false
            TC: O(n2) SC:O(1)

            Solution 2: Using Sorting
            Quick Sort or Heap Sort
            TC: O(nlogn) SC: O(1)

            Solution 3: Using Additional Space (HashMap)
            TC: O(n) SC: O(n)

        */

        HashSet<int> TempHashStore = new();
        foreach(int i in nums)
        {
            if(TempHashStore.Contains(i))
            {
                return true;
            }
            else
            {
                TempHashStore.Add(i);
            }
        }
        return false;
    }
}