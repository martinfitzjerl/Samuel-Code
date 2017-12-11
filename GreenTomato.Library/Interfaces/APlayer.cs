namespace GreenTomato.Library.Interfaces
{
    public abstract class APlayer : IPlayer
    {

        public Screen Screen {get; set;}

        public Power Power { get; set; }

        public Button Button {get; set; }
        protected APlayer()
        {
            Create();
        }

        protected virtual APlayer Create()
        {
            return this;

        }
        public string Forward()
        {
            throw new System.NotImplementedException();
        }
    }
}