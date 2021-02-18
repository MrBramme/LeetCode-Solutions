namespace LeetCode.Solutions.Medium
{
    public class SubrectangleQueries
    {
        private readonly int[][] _rectangle;

        public SubrectangleQueries(int[][] rectangle)
        {
            _rectangle = rectangle;
        }

        public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
        {
            for (var row = row1; row <= row2; row++)
            {
                for (var col = col1; col <= col2; col++)
                {
                    _rectangle[row][col] = newValue;
                }
            }
        }

        public int GetValue(int row, int col)
        {
            return _rectangle[row][col];
        }
    }
}
