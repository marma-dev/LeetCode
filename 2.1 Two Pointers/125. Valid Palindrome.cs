public class Solution {
    public bool IsPalindrome(string s) {
        /*
            1. What's a Palindrome?
            A: After removing all capital and all non-alphanumeric characters, it reads the same front andback.

            2. What characters to consider?
            A: a-z, A-Z, 0-9

            3. Can there be empty strng?
            A: yes

            4. Whats the length limit of the string? (Trying to know if we can enumerate or not)? Will it fit in memory, and can it be iterated using an int?)
            A: yes

            5.So how is the input given?
            A: String,  Input is already taken care of

            6. What's the return type?
            A: bool

            7. Do i need to raise exception, in case there isn't any alphanumeric characters?
            A: No

            8. Can there be concurrent read/write to the string, or a possibility that the input string can change while the program iterates over it?

            Requirements
            1. Case-Insensitive
            2. Consider only alphaNumberic and skip others
            3. Corner Cases
                a. Empty String
            4. Locking is not necessary

            SOLUTION 1: 
                BRUTE FORCE
                    Take a char array of the same length
                    iterate i over ip array and store ith element in n-ith position in the chararray
                    once the iteration is over
                    iterate over both array and check if the values at each index are same.

        */   
        // char[] second = new char[s.Length];

        // //storing the string s in to a char array in reverse order
        // for(int i =0; i<s.Length; i++)
        // {
        //     char[s.Length-1-i] = s[i];
        // }
        // //iterating through the string s and char array and checking if not palindrome
        // for(int i=0; i<s.Length; i++)
        // {
        //     if(char[i]!=s[i])
        //         return false;
        // }
        // return true;

        /*
        Solution 2: 2 pointer
            1 pointer at start, one at end
            1st ptr moves right and the other pointer moves left
            we continue to skip moves till a alphanumeric character is encountered
            one encountered we check both indecies for palindrome, i.e same char
        */

        s=ProcessString(s);
        for(int i=0, j=s.Length-1; i<s.Length && j>=0; )
        {

            //now both are at indecies with alphanumeriuc values
            if(s[i]!=s[j])
                return false;
            
            i++;
            j--;
        }
        return true;
    }
    public string ProcessString(string s)
    {
        List<char> ch = new();
        //remove nonalphanumeric characters
        //lowercase all capitals
        for(int i=0; i<s.Length; i++)
        {
            if(!IsAlphanumeric(s[i]))
            {
                continue;
            }
            //uppercase to lowercase
            if(s[i]>='A'&& s[i]<='Z')
                ch.Add((char)(s[i]+('a'-'A')));
            else
                ch.Add(s[i]);
        }
        return new string(ch.ToArray());
    }
    public bool IsAlphanumeric(char c)
    {
        //checking if the char is alphanumeric
        //check if small alphabets
        if(c>='a'&& c<='z')
            return true;
        
        //check for capital alphabets
        if(c>='A'&& c<='Z')
            return true;
        
        //check for numerics
        if(c>='0'&& c<='9')
            return true;
        
        //default case, doesn't match the above 
        return false;
    }
}