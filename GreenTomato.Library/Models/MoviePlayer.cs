namespace GreenTomato.Library
{
    public class MoviePlayer : IPlayer
    {
        private IMovie m;

        public MoviePlayer(IMovie)
        {
            m = new MovieUS();
        }

        public void Pause()
        {
            throw new System.NotImplementedException();
        }

        public string Forward()
        {
            return strinig.Format("{0}")
        }
        
        public MoviePlayer(IMovie movie)
        {
            m = movie;
        }

        public string Rewind()
        {
            return string.Format("{0} {1}", "rewind", m.ToString());
        }

        public delegate string Playing();//publisher subscriber model

        public event Playing Show;

        public void PlayMovie()
        {
            Show();
        }
    }
}