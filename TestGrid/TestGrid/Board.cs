using System;
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
            Turn = false;
            
        }

        public bool Turn { get; set; }

        public List<Piece> Pieces = new List<Piece>();


        public void ChangeTurn()
        {
            Turn = !Turn;
        }

        internal void PlacePiece(Piece p)
        {
             Pieces.Add(p);
        }
    }
}