namespace Sudoku_Solver.Models
{
    /// <summary>
    /// Model for 3x3 input block
    /// </summary>
    public class _InputBlockModel
    {
        // Set position for the block
        public int Position { get; set; }
        
        // Set if have a background color or not
        public bool Background { get; set; }
    }
}
