using ClassAdapterPattern.Client;

namespace ClassAdapterPattern
{
    public class BoardGameServiceAdapter : BoardGameService, IExternalBoardGameService
    {
        public void AddBoardGame(ExternalBoardGame newBoardGame)
        {
            var boardGame = new BoardGame
            {
                Id = newBoardGame.Id,
                Name = newBoardGame.Name,
                Active = !newBoardGame.IsDeleted
            };
            Add(boardGame);
        }

        public string GetBoardGameName(int boardGameId)
        {
            var boardGame = Get(boardGameId);
            if (boardGame != null)
                return boardGame.Name;
            return string.Empty;
        }

        public ExternalBoardGame GetNewBoardGame(int boardGameId)
        {
            var boardGame = Get(boardGameId);
            return new ExternalBoardGame
            {
                Id = boardGame.Id,
                Name = boardGame.Name,
                IsDeleted = !boardGame.Active
            };
        }

        public void DeleteBoardGame(int boardGameId)
        {
            Delete(boardGameId);
        }
    }
}