using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessSystem.Tabuleiro
{
    class Board
    {
        public int rows { get; set; }
        public int columns { get; set; }
        private Piece[,] piece;

        public Board(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            piece = new Piece[rows, columns];
        }
    }
}
