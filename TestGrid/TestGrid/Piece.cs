using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGrid
{
    public enum PieceColor
    {
        Red, Black
    }

    public class Piece
    {
        public int Index { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }

        public bool IsEmpty { get; set; }
        public PieceColor Color { get; set; }

    }
}

