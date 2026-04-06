public class Solution {
    public bool IsValidSudoku(char[][] board)
    {
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] columns = new HashSet<char>[9];
        HashSet<char>[] boxes = new HashSet<char>[9];

        for (int i = 0; i < 9; i++)
        {
            rows[i] = new HashSet<char>();
            columns[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                char value = board[i][j];

                if (value == '.')
                    continue;

                if (rows[i].Contains(value))
                    return false;

                rows[i].Add(value);

                if (columns[j].Contains(value))
                    return false;
                
                columns[j].Add(value);

                int boxIndex = (i / 3) * 3 + (j / 3);
                
                if (boxes[boxIndex].Contains(value))
                    return false;

                boxes[boxIndex].Add(value);
            }
        }
        return true;
    }
}
