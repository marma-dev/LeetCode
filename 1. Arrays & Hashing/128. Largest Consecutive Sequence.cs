public class Solution {
    public int LongestConsecutive(int[] nums) {
        //HashSet of all Elements
        //Starting with the First element 
                // Get the longest sequence containng the element
                // remove the elements from the hashset

        HashSet<int> setOfNums = new();
        foreach(var n in nums)
        {
            setOfNums.Add(n);
        }
        int largest = 0;
        foreach(var n in setOfNums)
        {
            int size = 1;
            //Scan Left
            int l= n-1;
            int r=n+1;
            
            while(setOfNums.Contains(l))
            {
                size++;
                setOfNums.Remove(l);
                l--;
            }
            while(setOfNums.Contains(r))
            {
                size++;
                setOfNums.Remove(r);
                r++;
            }

            setOfNums.Remove(n);
            if(size>largest)
                largest = size;
        }
        return largest;
    }
}