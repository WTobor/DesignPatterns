namespace DesignPatterns
{
    public class BoardGameServiceAdapter : BoardGameService, INewBoardGameService
    {
        public void AddBoardGame(NewBoardGame newBoardGame)
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

        public NewBoardGame GetNewBoardGame(int boardGameId)
        {
            var boardGame = Get(boardGameId);
            return new NewBoardGame
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