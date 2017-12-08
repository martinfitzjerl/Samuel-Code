namespace  GreenTomato.Library.Models

{
    public class Genre
    {
        public interface IMovie
        {
            public string Name { get; set; }

            public Genre() 
            { 
                Name = "Comedy"
            }

    
        }
    }
}