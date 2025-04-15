namespace Sudoku_Solver.Models
{
    /// <summary>
    /// Model for input main block (entire row 3x9)
    /// </summary>
    public class _MainBlockModel
    {
        // Set position of the main block
        public int Position { get; set; }

        // Set if have a background color or not
        public bool Background { get; set; }
    }
}
