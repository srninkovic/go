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
        public int Row { get { return Index / 21; }  }
        public int Col { get { return Index % 21; } }

        public bool GetNorth(ref int aIndex)
        {
            aIndex = -1;
            if (Row == 1)
            {
                return false;
            }
            aIndex = Index - 20;

            return true;

        }

        public bool GetEast(ref int aIndex)
        {
            aIndex = -1;
            if (Col == 20)
            {
                return false;
            }
            aIndex = Index + 1;

            return true;

        }

        public bool GetSouth(ref int aIndex)
        {
            aIndex = -1;
            if (Row == 20)
            {
                return false;
            }
            aIndex = Index + 20;

            return true;

        }

        public bool GetWest(ref int aIndex)
        {
            aIndex = -1;
            if (Col == 1)
            {
                return false;
            }
            aIndex = Index - 1;

            return true;

        }

        public bool IsEmpty { get; set; }
        public PieceColor Color { get; set; }

    }
}

