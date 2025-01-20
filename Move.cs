using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGenius1
{
    internal class Move
    {
        public int from;
        public int to;
        public bool capture;

        public Move()
        {
        }

        public Move(int from, int to)
        {
            this.from = from;
            this.to = to;
        }
    }
}
