namespace GreenTomato.Library.Model
{
    public static class TVPlayer
    {
        public static void Play()
        {
            var rp = new RadioPlayer();
        }
        
        

        protected override APlayer Create()
        {
            return new TVPlayer(){};
        }
    }
}