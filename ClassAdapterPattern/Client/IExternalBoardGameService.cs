using ClassAdapterPattern.Client;

namespace ClassAdapterPattern
{
    public interface IExternalBoardGameService
    {
        string GetBoardGameName(int boardGameId);

        ExternalBoardGame GetNewBoardGame(int boardGameId);

        void AddBoardGame(ExternalBoardGame newBoardGame);

        void DeleteBoardGame(int boardGameId);
    }
}