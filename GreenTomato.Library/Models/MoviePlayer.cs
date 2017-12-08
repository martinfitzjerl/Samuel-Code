namespace GreenTomato.Library
{
    public static class MoviePlayer : IPlayer //if class is static then every member has to be static
    {
        private static IMovie m; //make sure there is only one object, one thing and one thing only, everything has to be working on the same thing

        public static MoviePlayer(IMovie)//singleton we are connected to the same room but have our own space//static we are all stacked on each other, we cannot instantiate by using '"new"'
        {
            m = new MovieUS();
        }

        public static void Pause()
        {
            throw new System.NotImplementedException();
        }

        public static void Play()
        {
            return string.Format();
        }

        public static string Forward()
        {
            return string.Format("{0}");
        }
        
        public static MoviePlayer(IMovie movie)
        {
            m = movie;
        }

        public static string Rewind()
        {
            return string.Format("{0} {1}", "rewind", m.ToString());
        }

        public static delegate string Playing();//publisher subscriber model

        public static event Playing Show;

        public static void PlayMovie()
        {
            Show();
        }
    }
}