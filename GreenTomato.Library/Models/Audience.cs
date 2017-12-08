using System;
using collection;

namespace GreenTomato.Library.Models
{
    public class Audience
    {
        Func<IPlayer, IPlayer> Play = () => {return mp.Play(); };

        Func<IPlayer> Pause = (mp) => {return mp.Pause(); };

        public delegate string AudienceStuff();
        public delegate string Pause1();


        public string 

        private static IPlayer mp;

        public Audience(IMovie movie)
        {
            mp = new MoviePlayer(movie);
        }

        public void Watch()
        {
            return mp.play();
        }

        public void SnackBreak()
        {
            mp.pause();
        }

        public void Talk()
        {
            mp.Forward();
        }

        public void Leave()
        {
            mp.Rewind();
        }

        public string DoAction(Func<string> action)
        {
            return action();
        }

        public string DoAction(AudienceStuff action)
        {
            return action();
        }

        public void GoPlaying(MoviePlayer mo)
        {
            mo.Show += Watching;//when show happens call this
        }

        public string Watching()
        {
            response = "we are watching";
            return response;
        }

        public void Saving(MoviePlayer mo)
        {
            mo.Show += SaveToFile;
        }

        private string SaveToFile()
        {
            using(var f = File.AppendText("collection.txt"))
            {
                f.WriteLine(new MovieUS().ToString() + "\n");//file open and close, if any issue happens this block handles it
                GC.Collect();//GC. Garbage Collection
            }
            File.AppendAllText("collection.txt", new MovieUS().ToString() + "\n";
            return string.Empty;
        }
        IDisposable//mark var there and then get rid of it, garbage collection cannot be enforced, we just announce to go faster, gc collect has to pause application to analize which could slow stuff, but if you have a lot of objects being collected then Garbage collect, if you are drawing a lot of vectors you want to get rid of stuff like a ton of polygons temp, make sure previous frame is gone because it uses a lot of memory and CPU
        //using statement is a garbage collection

        private string SaveToFileXML()//xml serializer for help
        {
            var s = new XmlSerializer(typeof(List<MovieUS>));//when we give it a type it knows how to generate it, xml is not a string so we have to work it, we need to make it a stream, stream writer
            var f = new StreamWriter("collection.xml");

            s.Serializer(f, new MovieUS())//serialize into file a brand new movie, wants to control it and write it directly
            return string.Empty;//serialize by text and serialize by xml, serialize by xml is better because you have everything seperated by element
        

            
        }
/* 
        public void ReadFromFile()
        {
            var r = File.ReadAllLines("collection.txt");//to get more movies typeof(List<MovieUS>))

            foreach (var line in r)
            {
                var a = line.Split();

                if (a.Length > 3) {
                    if
                }
                //var//    //easy to write but hard to read when serializing this way
            }
        }
        */
        
        public void ReadFromFileXML()
        {
            var s = new XmlSerializer(typeof(List<MovieUS>));
            var r = new StreamReader("collection.xml");

            var o = (MovieUS)s.Deserialize(r);///*(MovieUS)error aka exception*take xml and put it into movie by using a plain object, we need to cast it to what we want it to be
            var o2 = s.Deserialize(r) as List<MovieUS>; //null if not exists json can be written in a better way than xml
        }
    }

    
}