namespace ObjectAdapterPattern.Client
{
    public class ExternalBoardGameService
    {
        public virtual string GetBoardGameName(int boardGameId)
        {
            //some logic
            return null;
        }

        public virtual ExternalBoardGame GetNewBoardGame(int boardGameId)
        {
            //some logic
            return null;
        }

        public virtual void AddBoardGame(ExternalBoardGame newBoardGame)
        {
            //some logic
        }

        public virtual void DeleteBoardGame(int boardGameId)
        {
            //some logic
        }
    }
}