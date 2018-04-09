using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace TestGrid
{
    internal class Board
    {
        struct Neigbours
        {
            //Piece N = null;
            //Piece E = null;
            //Piece S = null;
            //Piece W = null;
        }

        public Board()
        {
            
        }

        public bool Turn { get; set; }

        public List<Piece> Pieces = new List<Piece>();


        public void ChangeTurn()
        {
            Turn = !Turn;
        }

        private Piece GetPieceAtIndex(int aIndex)
        {
            foreach (Piece p in Pieces)
            {
                if (p.Index == aIndex)
                {
                    return p;
                }

            }

            return null;
        }

        internal void PlacePiece(Piece p)
        {
             Pieces.Add(p);


            // copy and paste 4 times
            int idx = -1;
            Piece pe = p;
            while (pe != null && pe.GetEast(ref idx))
            {
                if (GetPieceAtIndex(idx) == null || GetPieceAtIndex(idx).Color != p.Color) 
                    break;
                pe = GetPieceAtIndex(idx);
            }
            if (pe.Index - p.Index > 1)
            {
                int ludo = 0;
            }

            while (pe != null && pe.GetWest(ref idx))
            {
                if (GetPieceAtIndex(idx) == null || GetPieceAtIndex(idx).Color != p.Color)
                    break;
                pe = GetPieceAtIndex(idx);
            }
            if (pe.Index - p.Index > 1)
            {
                int ludo = 0;
            }

            while (pe != null && pe.GetNorth(ref idx))
            {
                if (GetPieceAtIndex(idx) == null || GetPieceAtIndex(idx).Color != p.Color)
                    break;
                pe = GetPieceAtIndex(idx);
            }
            if (pe.Index - p.Index > 1)
            {
                int ludo = 0;
            }

            while (pe != null && pe.GetSouth(ref idx))
            {
                if (GetPieceAtIndex(idx) == null || GetPieceAtIndex(idx).Color != p.Color)
                    break;
                pe = GetPieceAtIndex(idx);
            }
            if (pe.Index - p.Index > 1)
            {
                int ludo = 0;
            }
        }
    }
}