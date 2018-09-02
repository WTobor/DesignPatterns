namespace DesignPatterns
{
    public interface INewBoardGameService
    {
        string GetBoardGameName(int boardGameId);

        NewBoardGame GetNewBoardGame(int boardGameId);

        void AddBoardGame(NewBoardGame newBoardGame);

        void DeleteBoardGame(int boardGameId);
    }
}