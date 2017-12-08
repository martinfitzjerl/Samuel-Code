namespace GreenTomato.Library.Interfaces
{
    public abstract class APlayer : IPlayer
    {

        protected APlayer()
        {
            Create();
        }

        public virtual APlayer Create()
        {
            return;

        }
        public string Forward()
        {
            throw new System.NotImplementedException();
        }
    }
}