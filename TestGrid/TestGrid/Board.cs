using System;

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

        public bool Turn { get; set; }

        public void ChangeTurn()
        {
            Turn = !Turn;
        }

    }
}