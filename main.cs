public class Solution {
    public void Rotate(int[][] matrix) 
    {
        int n = matrix.Length;
        int j = 0;
        int index = 0;
        List<int> li = new List<int>();
        while(j < n)
        {
            for(int i = n - 1; i >= 0; --i)
            {
                li.Add(matrix[i][j]);
            }
            j++;
        }
        for(int i = 0; i < n; i++)
        {
            for(j = 0; j < n; j++)
            {
                matrix[i][j] = li[index];
                index++;
            }
        }
    }
}
