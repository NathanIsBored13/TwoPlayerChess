using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPlayerChess
{
	class Board
	{
		Cell[,] grid;
		public Board(Cell[,] grid)
		{
			this.grid = grid;
		}
	}
}
