using ObjectAdapterPattern.Client;

namespace ObjectAdapterPattern
{
    public class BoardGameServiceAdapter : ExternalBoardGameService
    {
        private readonly BoardGameService _boardGameService;

        public BoardGameServiceAdapter(BoardGameService boardGameService)
        {
            _boardGameService = boardGameService;
        }

        public override void AddBoardGame(ExternalBoardGame newBoardGame)
        {
            var boardGame = new BoardGame
            {
                Id = newBoardGame.Id,
                Name = newBoardGame.Name,
                Active = !newBoardGame.IsDeleted
            };

            _boardGameService.Add(boardGame);
        }

        public override ExternalBoardGame GetNewBoardGame(int boardGameId)
        {
            var boardGame = _boardGameService.Get(boardGameId);
            if (boardGame != null)
                return new ExternalBoardGame
                {
                    Id = boardGame.Id,
                    Name = boardGame.Name,
                    IsDeleted = !boardGame.Active
                };

            return null;
        }

        public override void DeleteBoardGame(int boardGameId)
        {
            _boardGameService.Delete(boardGameId);
        }
    }
}