using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns
{
    public class BoardGameService
    {
        public static List<BoardGame> boardGameList = new List<BoardGame>
        {
            new BoardGame
            {
                Id = 1, Name = "Catan", Active = true
            },
            new BoardGame
            {
                Id = 2, Name = "Gaia", Active = true
            },
        };

        public BoardGame Get(int boardGameId)
        {
            return boardGameList.FirstOrDefault(x => x.Id == boardGameId);
        }
	
	    public void Add(BoardGame boardGame)
	    {
	        boardGameList.Add(boardGame);
	    }
	
	    public void Delete(int boardGameId)
	    {
		    var boardGame = boardGameList.FirstOrDefault(x => x.Id == boardGameId);
	        if (boardGame != null)
	            boardGame.Active = false;
	    }
    }
}
