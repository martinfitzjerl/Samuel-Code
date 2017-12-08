using System.Collections.Generic
using GreenTomato.Library.Interfaces;

namespace GreenTomato.Library.Models
{
    public class MovieUS : IMovie
    {
        [XmlElement("Category")]//we can name it as a different name to make sense to the client or viewer

        public string Title { get; set;}

        public Genre Genre { get; set;}

        public List<Actor> Actors { get; set;}

        public MovieUS
        
        public override string ToString()
        {
            return s"{Title} {Genre} {Actors[0]}";//after C# version 7
            //return string.'format("{0} {1} {2}, Title, Genre, Actor';old C# format
        }
        public string Title { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException}

        public Genre { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException}

        public List<Actor> Actors{ get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException}

        public void Dispose()
        {
            GC.Collect();//when want to disppose ofo other objects, a movie genre, actors, we want to delete actors and genre, delete subcategories too
        }

        ~MovieUS()//Deconstructor
        {
            GC.GetGeneration;//if there is an error with GC then there could be memory leaks, keeps pushing and pushing until memory runs out
            GC.Collect();//garbage through iDispose, GC, Deconstructor Destructor?

        }
    }
}