public class Solution {
    public bool IsAnagram(string s, string t) {
        /*
        Solution 1: Sort both the arrays
        TC: O(nlogn); SC: O(1)

        Solution 2: Use Dictionary<char, int> to store char vs its occurences in the array
        TC: O(n); SC:O(n)

        Checks: 
        1. Length of both should be same
        2. Check for empty string/null values
        3. Check if the remaining Dictionary and t is not empty (as the case may be)

        */
        Dictionary<char, int> CharCount = new();
        //Adding every char of S in Dictionary
        foreach(char c in s)
        {
            if(CharCount.ContainsKey(c))
            {
                CharCount[c]++;
            }
            else
            {
                CharCount.Add(c,1);
            }
        }

        //Check every char of T in Dictionary
        foreach(char c in t)
        {
            if(CharCount.ContainsKey(c))
            {
                CharCount[c]--;
                if(CharCount[c] == 0)
                {
                    CharCount.Remove(c);
                }
            }
            else
            {
                return false;
            }
        }
        //Corner Case, if Dictionary has some elements left
        if(CharCount.Count > 0)
        {
            return false;
        }
        
        return true;

    }
}