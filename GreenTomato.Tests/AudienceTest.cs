using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GreenTomato.Tests
{
    [TestClass]
    public class AudienceTest
    {
        public Audience Audience {get; set;}

        public AudienceTest()
        {
            Audience = new Audience();
        }
        [TestMethod]
        public void AudienceShouldWatch()
        {
            var expected = "play " + typeof(MovieUS).ToString();
            var actual = Audience.Watch();

            Assert.isTrue(expected == actual);
        }

        public AudienceTest()
        {
            Audience = new Audience();
        }
        [TestMethod]
        public void AudienceShouldDo()
        {
            var m = new MovieUS();
            var mp = new MoviePlayer(m);
            AudienceStuff play = () => {return new MoviePlayer(new MovieCA()).Play();};
            Action<int> compute = (i) => {System.Console.WriteLine(i); };

            public delegate void Play1();
            public delegate string AudienceStuff();
            public delegate string Pause1(int i, bool b);

            Action<int> compute = (i) => {System.Console.WriteLine(i); };
            var expected = "play " + typeof(MovieCA).ToString();
            var actual = Audience.DoAction(play);
            Audience.Pause1 x = (i, b) => {return string.Empty; };

            Assert.isTrue(expected == actual);
        }

        public void AudienceWatching()
        {
            var expected = "we are watching";
            var mp = new Movie(new MovieMX());
            var au = new Audience(new MovieMX());

            au.GoPlaying(mp);//listen first
            mp.PlayMovie();//event
            

            Assert.AreEqual("we are watching", au.response);//someone has to be there in order to do the show for the event listener
        }
    }
}