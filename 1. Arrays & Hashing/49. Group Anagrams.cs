public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        /*
        Solution 1 :  Brute Force
        For Every String, 
            Check if other Strings are anagram
                -> store current string in a Dictionary

        

        */
        return Solution2(strs);
    }
    public IList<IList<string>> Solution2(string[] strs)
    {
        /*
        Solution 2:
            Have a Dictionary<String, List<String> 
            where we store the sorted string as the key and all the original strings anagrams in the list
            Lets assume there are N Strings in the list
            and Each String is M characters (avg)
            For every string, Sorting will take MlogM time,
            Since there are N strings, it will be M*NlogM time

            Storing and Fetching will take O(1) additional time

            O(N)
        */
        Dictionary<string, List<string>> anaGrp = new();
        foreach(string s in strs)
        {
            string ana = SortString(s);
            if(!anaGrp.ContainsKey(ana))
            {
                 anaGrp.Add(ana, new List<string>());
              
            }
            anaGrp[ana].Add(s);

        }
        IList<IList<string>> retVal= new List<IList<string>>();
        foreach(var kvp in anaGrp.ToArray())
        {
            retVal.Add(kvp.Value);
        }
        return retVal;


    }

    private string SortString(string s)
    {
        var charArr = s.ToCharArray();
        HeapSort(charArr, charArr.Length);//Can change this to Heap Sort for ONlogN and O(1)
        return new string(charArr);
    }

    private void MaxHeapify(char[] arr, int n, int p)
    {
        int largest = p;
        int left = 2*p + 1;
        int right = 2*p + 2;

        if(left<n && arr[left]>arr[largest])
            largest = left;
        if(right<n && arr[right]>arr[largest])
            largest = right;
        if(largest!=p)
        {
            char temp = arr[largest];
            arr[largest] = arr[p];
            arr[p] = temp;

            MaxHeapify(arr,n,largest);
        }
    }
    private void BuildMaxHeap(char[] arr, int n)
    {
        for(int i = n/2 - 1;i>=0;i-- )
        {
            MaxHeapify(arr,n,i);
        }
    }
    private void HeapSort(char[] arr, int n)
    {
        BuildMaxHeap(arr,n);
        //Pop top to back and reduce the size of heap
        for(int i =n-1; i>=0; i--)
        {
            char temp = arr[i];
            arr[i] = arr[0];
            arr[0] = temp;

            MaxHeapify(arr,i,0);
        }
    }
}