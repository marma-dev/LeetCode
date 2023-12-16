public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        return Solution1(nums,k);
    }
    public int[] Solution1(int[] nums, int k){
        /*
            BRUTE FORCE:
            For each element, look for how many same elements are there in the array 
            O(n2)

            SMART: 
            Save in Dictionary while iterating through the array


        */
        Dictionary<int,int> Frequency = new();
        foreach(int i in nums)
        {
            if(!Frequency.ContainsKey(i))
            {
                Frequency.Add(i,1);
            }
            else
            {
                Frequency[i]++;
            }
        }

        //Sort the dictionary based on the frequency
        var result = Frequency.OrderByDescending(x=>x.Value).Select(x=> x.Key).Take(k);
        return result.ToArray();
    }
}