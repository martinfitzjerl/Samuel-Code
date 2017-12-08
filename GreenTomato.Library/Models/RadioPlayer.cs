namespace GreenTomato.Library.Models
{
    public class RadioPlayer//Singleton model//printing seperate documents in the same printer, all of us can use the same printer to print our own document
    //static we all are printing the same document with the same printer
    {
        private static RadioPlayer rp = new RadioPlayer();

        private RadioPlayer()
        {
            
        }


        public static RadioPlayer Create()
        {
            if(rp == null)
            {
                lock(rp)//if it is null we can lock the variable
                {
                    rp = new RadioPlayer();
                }
                {
                    return rp;
                }
            }


            
        }
    }
}