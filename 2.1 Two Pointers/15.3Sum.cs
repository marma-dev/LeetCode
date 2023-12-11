public class Solution {
    /*
        int array,
        return triplets a[i], a[j], a[k] and sum of these = 0
        i != j != k

        q1.are the nums sorted?
            no
        q2. can there be fractions? 
            no
        q3. what to return?
            IList<IList<int>> with values
        q4. can the ans contain permutations of the a triplet or should be unique?
            Attempt for unique

    */

    /*
        SOLUTION:
            for every i from 0 to n-3, 
                j = i+1 to n-2,
                    k = j+1 to n-1;
                        check if matches and add to list
                        O(n3)

            sort the elements of ans list
                O(3n)
            
             and remove the same ones
                for each element look for same ones and remove from list
                O(n2)
    */

    /*
        SOLTUON 2:
            Sort the list
                TC- O(nlogn) //Heap Sort, or Quick Sort or INTRO SORT//
            
            for every i from 0 to n-3, 
                j = i+1 to n-2,
                    k = j+1 to n-1;
                        check if matches and add to list
                            Skip while same as kth element
                    skip while same as jth element
                skip while same as ith element
                        O(n3)

    */

    /*
        SOLUTION 3:
            Sort the list
                TC- O(nlogn) //Heap Sort, or Quick Sort or INTRO SORT//

            Dictionary<number,List<indecies>>
              or every i from 0 to n-3, 
                Dictionary.Remove(checkVal, i) //remove ith occurence, and if list empty, remove the entry
                j = i+1 to n-2,
                    Dictionary.Remove(checkVal, j) //remove jth occurence, and if list empty, remove the entry
                    checkVal = 0 - (a[i]+a[j])
                    if checkVal exits in dictionary
                        List.Count>=1 
                                Add to ans
                                Dictionary.RemoveEntry(checkVal) //remove kth occurence, and if list empty, remove the entry

    */
    public IList<IList<int>> ThreeSum(int[] nums) {
        /*
        SOLTUON 2:
            Sort the list
                TC- O(nlogn) //Heap Sort, or Quick Sort or INTRO SORT//
            
            for every i from 0 to n-3, 
                toFindSum = 0 - a[i];

                l = i+1  , r = n-1
                while(l<r)
                {
                    curSum = a[l]+a[r]
                    if eq
                        add
                            skip j till same

                    if(curSum < toFindSum)
                    {
                        r--;
                    }
                    
                }

    */
        IList<IList<int>> ans = new List<IList<int>>();
        Array.Sort(nums);
        //-4,-1,-1,0,1,2
        //* , i ,j,*,*,k
        int n = nums.Length;
        for(int i = 0; i<n-2; i++)
        {
            int SumToGet = 0 - nums[i];
            int l = i+1;
            int r = n-1;
            while(l<r)
            {
                int curSum = nums[l] + nums[r];
                if(curSum==SumToGet)
                {
                    List<int> a = new();
                    a.Add(nums[i]);
                    a.Add(nums[l]);
                    a.Add(nums[r]);

                    ans.Add(a);
                    
                }
                else if(curSum<SumToGet)
                {
                    l++;
                    continue;
                }
                else
                {
                    r--;
                    continue;
                }
                
                while(l+1<r && nums[l+1]==nums[l])
                {
                    l++;
                }
                
                while(l<r-1 && nums[r-1]==nums[r])
                {
                    r--;
                }
                l++;
                r--;
            }            
            while(i+1 < n-2 && nums[i+1]==nums[i])
            {
               i++;
            }
        }
        return ans;
    }
}