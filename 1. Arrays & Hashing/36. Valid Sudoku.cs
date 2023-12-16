public class Solution {
    public bool IsValidSudoku(char[][] board) {
        //Check Row
    int n = board[0].Length;
    
    for(int i = 0; i<n; i++)
    {
        HashSet<char> RowSet = new();
        HashSet<char> ColSet = new();
        for(int j = 0; j<n;j++)
        {
            if(board[i][j]!='.' && RowSet.Contains(board[i][j]))
                return false;
            RowSet.Add(board[i][j]);

            if(board[j][i]!='.' && ColSet.Contains(board[j][i]))
                return false;
            ColSet.Add(board[j][i]);
        }
            
    }
    
    for(int i = 0; i<n; i++)
    {
        HashSet<char> BlockSet = new();
        for(int j= (3*(i%3)) + 0; j<(3*(i%3))+3; j++)
        {
           for(int k=(3*(i/3))+0; k<(3*(i/3))+3;k++)
           {
                if(board[j][k]!='.' && BlockSet.Contains(board[j][k]))
                    return false;
                BlockSet.Add(board[j][k]);
           }    
        }
    }
    return true;
    }
    /*
        Solution 1:
        for every element - > O(n2*n) = On3
        Check Row; (n)
        Check Column (n)
        Check Box (n)

    */

    /*
        Solution 2:
            Check row for correctnes - N rows, with N entries ON2
            Check column for correctness
            Check Box for correctness
    */

    
}