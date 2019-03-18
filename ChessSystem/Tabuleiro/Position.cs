using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessSystem.Tabuleiro
{
    class Position
    {
        public int row { set; get; }
        public int column { set; get; }

        public Position(int row, int column)
        {
            this.row = row;
            this.column = column;
        }

        public override string ToString()
        {
            return row + ", " + column;
        }
    }
}
